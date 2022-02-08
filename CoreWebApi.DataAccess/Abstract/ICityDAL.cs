using CoreWebApi.Core.DataAccess;
using CoreWebApi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebApi.DataAccess.Abstract
{
    public interface ICityDAL : IEntityRepository<City>
    {
        List<City> GetCityByCountryId(int? id);
    }
}
