using Carpool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Services
{
    public interface IAutomobilService
    {
        List<Model.Automobil> Get(AutomobilSearchRequest request);
        Model.Automobil GetById(int id);
        Model.Automobil Insert(AutomobilInsertRequest request);
        Model.Automobil Update(int id,AutomobilInsertRequest request);
    }
}
