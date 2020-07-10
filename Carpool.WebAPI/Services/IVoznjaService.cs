using Carpool.Model;
using Carpool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Services
{
    public interface IVoznjaService: ICRUDService<Model.Voznja, VoznjaSearchRequest, VoznjaUspertRequest, VoznjaUspertRequest>
    {
        List<Model.Voznja> Recommend(int id);
    }
}
