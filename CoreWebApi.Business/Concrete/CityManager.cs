using CoreWebApi.Business.Abstract;
using CoreWebApi.DataAccess.Abstract;
using CoreWebApi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebApi.Business.Concrete
{
    public class CityManager : ICityService
    {
        private readonly ICityDAL _cityDAL;
        public CityManager(ICityDAL cityDAL)
        {
            _cityDAL = cityDAL;
        }
        public void Create(City entity)
        {
            _cityDAL.Add(entity);
        }

        public void Delete(City entity)
        {
            _cityDAL.Delete(entity);
        }

        public List<City> GetAll()
        {
            return _cityDAL.GetAll();
        }

        public City GetById(int? id)
        {
            return _cityDAL.Get(i => i.Id == id);
        }

        public List<City> GetCityByCountryId(int? id)
        {
            return _cityDAL.GetCityByCountryId(id);
        }

        public void Update(City entity)
        {
            _cityDAL.Update(entity);
        }
    }
}
