using CoreWebApi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebApi.Business.Abstract
{
    public interface ICityService : IGenericService<City>
    {
        List<City> GetCityByCountryId(int? id);
    }
}
