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

namespace Carpool.WebAPI.Services
{
    public class KorisnikService : IKorisnikService
    {
        private readonly CarpoolContext _context;
        private readonly IMapper _mapper;
        public KorisnikService(CarpoolContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
            var query = _context.Korisnici.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }
            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }

            var list = query.ToList();

            var modelList = new List<Model.Korisnik>();

            modelList = list.Select(l => new Model.Korisnik
            {
                BrojTelefona = l.BrojTelefona,
                Email = l.Email,
                Ime = l.Ime,
                KorisnickoIme = l.KorisnickoIme,
                Prezime = l.Prezime,
                KorisnikID = l.KorisnikID,

                UlogaNaziv = _context.KorisniciUloge.Where(u => u.KorisnikId == l.KorisnikID).Select(u => u.Uloga.Naziv).ToList(),

                KorisniciUloge = l.KorisniciUloge.Select(x => new Model.KorisniciUloge
                {
                    DatumIzmjene = x.DatumIzmjene,
                    KorisnikId = x.KorisnikId,
                    KorisnikUlogaId = x.KorisnikUlogaId,
                    UlogaId = x.UlogaId
                }).ToList()

            }).ToList();

            return modelList;
        }

        public Model.Korisnik GetById(int id)
        {
            var korisnik = _context.Korisnici.Find(id);

            return _mapper.Map<Model.Korisnik>(korisnik);
        }

        public Model.Korisnik Insert(KorisnikInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnik>(request);

            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne slazu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            entity.GradID = 4; //dodati dropdown


            _context.Korisnici.Add(entity);
            _context.SaveChanges();

            foreach (var uloga in request.Uloge)
            {
                var addUloge = new Model.KorisniciUloge
                {
                    UlogaId = uloga,
                    KorisnikId = entity.KorisnikID,
                    DatumIzmjene = DateTime.Now
                };

                var listUloge = _mapper.Map<Database.KorisniciUloge>(addUloge);
                _context.KorisniciUloge.Add(listUloge);
            }

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnik>(entity);
        }

        public Model.Korisnik Update(int id, KorisnikInsertRequest request)
        {
            var entity = _context.Korisnici.Find(id);

            _mapper.Map(request, entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new UserException("Passwordi se ne slazu");
                }
            }
            //todo update password
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnik>(entity);
        }
    }
}
