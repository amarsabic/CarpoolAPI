using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Carpool.Model;
using Carpool.WebAPI.Database;

namespace Carpool.WebAPI.Services
{
    public class GradService : BaseCRUDService<Model.Grad, object, Database.Grad, Model.Grad, Model.Grad>
    {
        public GradService(CarpoolContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Grad> Get(object search)
        {
            var list = _context.Gradovi.OrderBy(g=>g.Naziv).ToList();

            return _mapper.Map<List<Model.Grad>>(list);
        }
    }
}
