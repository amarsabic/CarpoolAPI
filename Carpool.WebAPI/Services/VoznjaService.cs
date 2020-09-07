using AutoMapper;
using Carpool.Model;
using Carpool.Model.Requests;
using Carpool.WebAPI.Database;
using Carpool.WebAPI.Exceptions;
using Carpool.WebAPI.Helpers;
using Carpool.WebAPI.ML;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Services
{
    public class VoznjaService : BaseCRUDService<Model.Voznja, VoznjaSearchRequest, Database.Voznja, VoznjaUspertRequest, VoznjaUspertRequest>, IVoznjaService
    {
        //STEP 1: Create MLContext to be shared across the model creation workflow objects 
        
        static ITransformer model = null;

        private readonly IHttpContextAccessor _httpContext;
        public VoznjaService(CarpoolContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context, mapper)
        {
            _httpContext = httpContext;
        }

        public override Model.Voznja Update(int id, VoznjaUspertRequest request)
        {
            var entity = _context.Voznje.Find(id);
            if (request.ZavrsiVoznju)
            {
                entity.IsAktivna = false;
                _context.SaveChanges();
                return _mapper.Map<Model.Voznja>(entity);
            }

            if (entity.AutomobilID != request.AutomobilID)
            {
                var stariAuto = _context.Autmobili.Find(entity.AutomobilID);
                stariAuto.IsAktivan = false;

                var noviAuto = _context.Autmobili.Find(request.AutomobilID);
                //if (noviAuto.IsAktivan)
                //{
                //    throw new UserException("Odabrani automobil " + noviAuto.Naziv+" "+noviAuto.Model+" je trenutno zauzet!");
                //}
                noviAuto.IsAktivan = true;
            }

            var usputniGradovi = _context.UsputniGradovi.Where(u => u.VoznjaID == entity.VoznjaID).ToList();
            foreach (var item in usputniGradovi)
            {
                _context.UsputniGradovi.Remove(item);
            }
            _context.SaveChanges();

            foreach (var usputni in request.UsputniGradoviGrad)
            {
                entity.UsputniGradovi.Add(new Database.UsputniGradovi
                {
                    GradPoRedu = 0,
                    CijenaUsputni = 0,
                    VoznjaID = entity.VoznjaID,
                    GradID = usputni.GradID
                });
            }
            _context.SaveChanges();

            return _mapper.Map<Model.Voznja>(entity);
        }

        public override Model.Voznja Delete(int id)
        {
            var entity = _context.Voznje.Find(id);

            var auto = _context.Autmobili.Find(entity.AutomobilID);
            auto.IsAktivan = false;


            var rezervacije = _context.Rezervacije.Where(u => u.VoznjaID == id).ToList();
            foreach (var item in rezervacije)
            {
                _context.Rezervacije.Remove(item);
            }

            var usputniGradovi = _context.UsputniGradovi.Where(u => u.VoznjaID == id).ToList();
            foreach (var item in usputniGradovi)
            {
                _context.UsputniGradovi.Remove(item);
            }
            _context.SaveChanges();

            _context.Voznje.Remove(entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Voznja>(entity);
        }

        public override Model.Voznja Insert(VoznjaUspertRequest request)
        {
            var userId = int.Parse(_httpContext.GetUserId());

            var entity = _mapper.Map<Database.Voznja>(request);
            entity.VozacID = userId;

            _context.Voznje.Add(entity);
            _context.SaveChanges();

            foreach (var usputni in request.UsputniGradoviGrad)
            {
                _context.UsputniGradovi.Add(new Database.UsputniGradovi()
                {
                    VoznjaID = entity.VoznjaID,
                    CijenaUsputni = 0,
                    GradID = usputni.GradID,
                    GradPoRedu = 0
                });
            }

            var auto = _context.Autmobili.Find(request.AutomobilID);
            auto.IsAktivan = true;

            _context.SaveChanges();

            var model = _mapper.Map<Model.Voznja>(entity);
            model.UsputniGradoviE = entity.UsputniGradovi.Where(x => x.VoznjaID == entity.VoznjaID).Select(x => new Model.UsputniGradovi
            {
                UsputniGradoviID = x.UsputniGradoviID,
                VoznjaID = x.VoznjaID,
                CijenaUsputni = x.CijenaUsputni,
                GradID = x.GradID,
                GradPoRedu = x.GradPoRedu
            }).ToList();

            return model;
        }

        public override Model.Voznja GetById(int id)
        {
            var result = _context.Voznje.Include(item => item.UsputniGradovi).Where(item => item.VoznjaID == id).Select(item => new Model.Voznja
            {
                AutomobilID = item.AutomobilID,
                AutomobilNazivModel = item.Automobil.Naziv + " " + item.Automobil.Model,
                DatumObjave = item.DatumObjave,
                DatumPolaska = item.DatumPolaska,
                GradPolaskaID = item.GradPolaskaID,
                GradPolaska = item.GradPolaska.Naziv,
                GradDestinacijaID = item.GradDestinacijaID,
                GradDestinacija = item.GradDestinacija.Naziv,
                IsAktivna = item.IsAktivna,
                VozacID = item.VozacID,
                KorisnickoIme = item.Vozac.Korisnik.KorisnickoIme,
                PunaCijena = item.PunaCijena,
                SlobodnaMjesta = item.SlobodnaMjesta,
                VrijemePolaska = item.VrijemePolaska,
                VoznjaID = item.VoznjaID,
                UsputniGradoviE = item.UsputniGradovi.Select(y => new Model.UsputniGradovi()
                {
                    CijenaUsputni = y.CijenaUsputni,
                    GradID = y.GradID,
                    Grad = _mapper.Map<Model.Grad>(y.Grad),
                    GradPoRedu = y.GradPoRedu,
                    UsputniGradoviID = y.UsputniGradoviID,
                    Voznja = _mapper.Map<Model.Voznja>(y.Voznja),
                    VoznjaID = y.VoznjaID
                }).ToList(),
                UsputniGradoviGrad = item.UsputniGradovi.Select(x => new Model.Grad
                {
                    GradID = x.GradID,
                    Naziv = _context.Gradovi.Where(g => g.GradID == x.GradID).Select(g => g.Naziv).FirstOrDefault()
                }).ToList(),
                UsputniGradoviNaziv = item.UsputniGradovi.Select(u => u.Grad.Naziv).ToList()
            }).FirstOrDefault();

            return _mapper.Map<Model.Voznja>(result);
        }

        public override List<Model.Voznja> Get(VoznjaSearchRequest search)
        {
            var userId = int.Parse(_httpContext.GetUserId());

            var query = _context.Set<Database.Voznja>().AsQueryable();

            if (search?.GradPolaskaID.HasValue == true)
            {
                query = query.Where(x => x.GradPolaskaID == search.GradPolaskaID);
            }
            if (search.IsVozac)
            {
                query = query.Where(x => x.VozacID == userId && x.IsAktivna == true);
            }
            if (search.IsZavrsena)
            {
                query = query.Where(x => !x.IsAktivna);
            }
            if (search.IsVozacZavrsene)
            {
                query = query.Where(x => x.VozacID == userId && x.IsAktivna == false);
            }
            if (search.IsVozacZavrseneDesktop)
            {
                query = query.Where(x => x.VozacID == search.VozacID && x.IsAktivna == false);
            }
            if (search?.VozacID!=null)
            {
                query = query.Where(x => x.VozacID==search.VozacID);
            }
            if (search.IsSlobodnaMjesta)
            {
                query = query.Where(x => x.SlobodnaMjesta != 0 && x.IsAktivna == true);
            }
            if (search.Aktivne)
            {
                query = query.Where(x => x.IsAktivna == true);
            }

            if (search.PosljednjeVoznje)
            {
                query = query.OrderByDescending(x => x.DatumObjave).Take(3);

            }
            else
            {
                query = query.OrderByDescending(x => x.DatumObjave);

            }

            if (search.SearchFromHomePage)
            {
                var searchDatum = search.DatumPolaska.Date;
                query = query.Where(x => (x.GradPolaskaID == search.GradPolaskaID && x.GradDestinacijaID == search.GradDestinacijaID) || (x.UsputniGradovi.Any(u => u.GradID == search.GradDestinacijaID) && x.GradPolaskaID == search.GradPolaskaID));
                query = query.Where(x => x.IsAktivna);
                query = query.Where(x => x.DatumPolaska == searchDatum);
            }


            var result = query.Select(item => new Model.Voznja
            {
                AutomobilNazivModel = item.Automobil.Naziv + " " + item.Automobil.Model,
                DatumObjave = item.DatumObjave,
                DatumPolaska = item.DatumPolaska,
                GradPolaska = item.GradPolaska.Naziv,
                GradDestinacija = item.GradDestinacija.Naziv,
                IsAktivna = item.IsAktivna,
                KorisnickoIme = item.Vozac.Korisnik.KorisnickoIme,
                PunaCijena = item.PunaCijena,
                SlobodnaMjesta = item.SlobodnaMjesta,
                VrijemePolaska = item.VrijemePolaska,
                VoznjaID = item.VoznjaID
            }).ToList();

            return _mapper.Map<List<Model.Voznja>>(result);
        }

        public List<Model.Voznja> Recommend() //korisnikId
        {
            MLContext mlContext = new MLContext();
            var id = int.Parse(_httpContext.GetUserId());


            //STEP 2: Read the trained data using TextLoader by defining the schema for reading the product co-purchase dataset
            //        Do remember to replace amazon0302.txt with dataset from https://snap.stanford.edu/data/amazon0302.html


            var tmpVoznje = _context.Voznje.Include("Rezervacije").Where(v => !v.IsAktivna).ToList(); //sve zavrsene voznje i njihove rezervacije

                var data = new List<ProductEntry>();
                foreach (var x in tmpVoznje)
                {
                    if (x.Rezervacije.Count > 1)
                    {
                        var distinctRezervacijaId = x.Rezervacije.Select(y => y.KorisnikID).ToList();

                        distinctRezervacijaId.ForEach(y =>
                        {
                            var relatedRezervacija = x.Rezervacije.Where(z => z.KorisnikID != y).ToList();

                            relatedRezervacija.ForEach(z =>
                            {
                                data.Add(new ProductEntry() { ProductID = (uint)y, CoPurchaseProductID = (uint)z.KorisnikID }); // iz rezervacija na voznji su bili i ovi korisnici
                            });
                        });
                    }
                }

            if (data.Count() == 0)
            {
                return new List<Model.Voznja>();
            }

                var traindata = mlContext.Data.LoadFromEnumerable(data);

                //STEP 3: Your data is already encoded so all you need to do is specify options for MatrxiFactorizationTrainer with a few extra hyperparameters
                //        LossFunction, Alpa, Lambda and a few others like K and C as shown below and call the trainer. 
                MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
                options.MatrixColumnIndexColumnName = nameof(ProductEntry.ProductID);
                options.MatrixRowIndexColumnName = nameof(ProductEntry.CoPurchaseProductID);
                options.LabelColumnName = "Label";
                options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
                options.Alpha = 0.01;
                options.Lambda = 0.025;
                // For better results use the following parameters
                //options.K = 100;
                options.C = 0.00001;

                //Step 4: Call the MatrixFactorization trainer by passing options.
                var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);


                //STEP 5: Train the model fitting to the DataSet
                //Please add Amazon0302.txt dataset from https://snap.stanford.edu/data/amazon0302.html to Data folder if FileNotFoundException is thrown.
                ITransformer model = est.Fit(traindata);

          
                //STEP 6: Create prediction engine and predict the score for Product 63 being co-purchased with Product 3.
                //        The higher the score the higher the probability for this particular productID being co-purchased 

            

                var allVoznje = _context.Korisnici.Where(k => k.KorisnikID != id);
                var predictionResult = new List<Tuple<Database.Korisnik, float>>();

                foreach (var item in allVoznje)
                {
                    var predictionengine = mlContext.Model.CreatePredictionEngine<ProductEntry, Copurchase_prediction>(model);
                    var prediction = predictionengine.Predict(
                                             new ProductEntry()
                                             {
                                                 ProductID = (uint)id,
                                                 CoPurchaseProductID = (uint)item.KorisnikID
                                             });

                    predictionResult.Add(new Tuple<Database.Korisnik, float>(item, prediction.Score));
                }
               

                var finalResult = predictionResult.OrderByDescending(x => x.Item2).Select(x => x.Item1).Take(3).ToList();

                var final = new List<Model.Voznja>();
                foreach (var korisnik in finalResult)
                {
                    var voznja = _context.Voznje.Include("Rezervacije").Where(v => v.IsAktivna && v.VozacID != id && v.Rezervacije.Any(r => r.KorisnikID == korisnik.KorisnikID)).Select(item => new Model.Voznja
                    {
                        AutomobilNazivModel = item.Automobil.Naziv + " " + item.Automobil.Model,
                        DatumObjave = item.DatumObjave,
                        DatumPolaska = item.DatumPolaska,
                        GradPolaska = item.GradPolaska.Naziv,
                        GradDestinacija = item.GradDestinacija.Naziv,
                        IsAktivna = item.IsAktivna,
                        KorisnickoIme = item.Vozac.Korisnik.KorisnickoIme,
                        PunaCijena = item.PunaCijena,
                        SlobodnaMjesta = item.SlobodnaMjesta,
                        VrijemePolaska = item.VrijemePolaska,
                        VoznjaID = item.VoznjaID
                    }).FirstOrDefault();

                    final.Add(voznja);
                }

                return _mapper.Map<List<Model.Voznja>>(final);
        }
    }
}
