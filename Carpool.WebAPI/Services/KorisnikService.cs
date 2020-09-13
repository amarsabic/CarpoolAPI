using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Carpool.Model;
using Carpool.Model.Requests;
using Carpool.WebAPI.Database;
using Carpool.WebAPI.Exceptions;
using Carpool.WebAPI.Helpers;
using Microsoft.AspNetCore.Http;

namespace Carpool.WebAPI.Services
{
    public class KorisnikService : IKorisnikService
    {
        private readonly IHttpContextAccessor _httpContext;
        private readonly CarpoolContext _context;
        private readonly IMapper _mapper;
        public KorisnikService(CarpoolContext context, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _context = context;
            _mapper = mapper;
            _httpContext = httpContext;
        }

        public Model.Korisnik Authenticiraj(string username, string pass)
        {
            var korisnik = _context.Korisnici.Where(k => k.KorisnickoIme == username).FirstOrDefault();

            if (korisnik != null)
            {
                var noviHash = GenerateHash(korisnik.LozinkaSalt, pass);

                if (noviHash == korisnik.LozinkaHash)
                {
                    return _mapper.Map<Model.Korisnik>(korisnik);
                }
            }
            return null;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public List<Model.Korisnik> Get(KorisniciSearchRequest request)
        {
            var userId = int.Parse(_httpContext.GetUserId());

            var query = _context.Korisnici.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }
            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }
            if (request.IsKorisnik)
            {
                query = query.Where(x => x.KorisnikID == userId);
            }
            if (request.IsAdmin)
            {
                query = query.Where(x => x.KorisniciUloge.Any(c => c.KorisnikId == x.KorisnikID));
            }
            var list = query.ToList();

            return _mapper.Map<List<Model.Korisnik>>(list);
        }
        public Model.Korisnik Auth()
        {
            var userId = int.Parse(_httpContext.GetUserId());

            if (userId != 0)
            {
                var korisnik = _context.Korisnici.Find(userId);
                return _mapper.Map<Model.Korisnik>(korisnik);
            }
            else
            {
                var korisnik = _context.Korisnici.Find(userId);
                return _mapper.Map<Model.Korisnik>(korisnik);
            }
        }

        public Model.Korisnik GetById(int id)
        {
            var userId = int.Parse(_httpContext.GetUserId());

            if (id != 0)
            {
                var korisnik = _context.Korisnici.Find(id);
                return _mapper.Map<Model.Korisnik>(korisnik);
            }
            else
            {
                var korisnik = _context.Korisnici.Find(userId);
                return _mapper.Map<Model.Korisnik>(korisnik);
            }
        }

        public Model.Korisnik Insert(KorisnikInsertRequest request)
        {
            var getAll = _context.Korisnici.ToList();
            foreach (var k in getAll)
            {
                if (k.KorisnickoIme == request.KorisnickoIme)
                    throw new UserException("Korisničko ime već postoji!");
                if (k.Email == request.Email)
                    throw new UserException("Već postoji profil registrovan na " + request.Email);
            }

            var entity = _mapper.Map<Database.Korisnik>(request);

            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne slazu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            entity.IsVozac = false;

            _context.Korisnici.Add(entity);
            _context.SaveChanges();

            if (request.Uloge.Count != 0)
            {
                foreach (var uloga in request.Uloge)
                {
                    entity.KorisniciUloge.Add(new Database.KorisniciUloge
                    {
                        KorisnikId = entity.KorisnikID,
                        DatumIzmjene = DateTime.Now,
                        UlogaId = uloga
                    });
                }
            }

            _context.SaveChanges();

            var model = new Model.Korisnik
            {
                KorisnikID = entity.KorisnikID,
                BrojTelefona = entity.BrojTelefona,
                DatumRodjenja = entity.DatumRodjenja,
                Email = entity.Email,
                GradID = entity.GradID,
                Ime = entity.Ime,
                IsVozac = entity.IsVozac,
                KorisnickoIme = entity.KorisnickoIme,
                Prezime = entity.Prezime,
                Slika = entity.Slika
            };

            model.KorisniciUloge = new List<Model.KorisniciUloge>();
            foreach (var item in entity.KorisniciUloge)
            {
                model.KorisniciUloge.Add(new Model.KorisniciUloge
                {
                    DatumIzmjene = item.DatumIzmjene,
                    KorisnikId = item.KorisnikId,
                    KorisnikUlogaId = item.KorisnikUlogaId,
                    UlogaId = item.UlogaId
                });
            }

            return model;
        }

        public Model.Korisnik Update(int id, KorisnikInsertRequest request)
        {
            var entity = _context.Korisnici.Find(id);

            if ((!string.IsNullOrWhiteSpace(request.Password)))
            {

                if (request.Password != request.PasswordConfirmation)
                {
                    throw new UserException("Passwordi se ne slazu");
                }

                var korisnik = _context.Korisnici.Find(int.Parse(_httpContext.GetUserId()));

                var noviHash = GenerateHash(korisnik.LozinkaSalt, request.OldPassword);

                if (noviHash == korisnik.LozinkaHash)
                {
                    korisnik.LozinkaSalt = GenerateSalt();
                    korisnik.LozinkaHash = GenerateHash(korisnik.LozinkaSalt, request.Password);
                    _context.SaveChanges();
                    return _mapper.Map<Model.Korisnik>(request);

                }
                throw new UserException("Unijeli se pogrešnu lozinku.");
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnik>(entity);
        }

        private void UpdatePassword(KorisnikInsertRequest request)
        {
            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne slazu");
            }

            var korisnik = _context.Korisnici.Find(int.Parse(_httpContext.GetUserId()));

            var noviHash = GenerateHash(korisnik.LozinkaSalt, request.OldPassword);

            if (noviHash == korisnik.LozinkaHash)
            {
                korisnik.LozinkaSalt = GenerateSalt();
                korisnik.LozinkaHash = GenerateHash(korisnik.LozinkaSalt, request.Password);
                _context.SaveChanges();
                return;
            }

            throw new UserException("Unijeli se pogrešnu lozinku.");
        }

        public Model.Korisnik Delete(int id)
        {
            var korisnik = _context.Korisnici.Find(id);
            _context.Korisnici.Remove(korisnik);
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnik>(korisnik);
        }
    }
}
