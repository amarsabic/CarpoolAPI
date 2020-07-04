using AutoMapper;
using Carpool.Model.Requests;
using Carpool.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Services
{
    public class UsputniGradoviService : BaseCRUDService<Model.UsputniGradovi, UsputniGradoviSearchRequest, Database.UsputniGradovi, UsputniGradoviUpsertRequest, UsputniGradoviUpsertRequest>
    {
        public UsputniGradoviService(CarpoolContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
