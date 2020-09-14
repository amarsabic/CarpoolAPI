using Carpool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Services
{
   public interface IOcjenaService: ICRUDService<Model.Ocjene, OcjenaSearchRequest, OcjenaUpsertRequest, OcjenaUpsertRequest>
    {
    }

}
