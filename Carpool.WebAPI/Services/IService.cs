using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Services
{
    public interface IService<T, TSearch> // klasa,filter
    {
        List<T> Get(TSearch search);
        T GetById(int id);
    }
}
