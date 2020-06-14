using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Carpool.WebAPI.Database;

namespace Carpool.WebAPI.Services
{
    public class GradService : BaseCRUDService<Model.Grad, object, Database.Grad, Model.Grad, Model.Grad>
    {
        public GradService(CarpoolContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
