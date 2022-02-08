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
    public class CountryManager : ICountryService
    {
        private readonly ICountryDAL _countryDAL;
        public CountryManager(ICountryDAL countryDAL)
        {
            _countryDAL = countryDAL;
        }
        public void Create(Country entity)
        {
            _countryDAL.Add(entity);
        }

        public void Delete(Country entity)
        {
            _countryDAL.Delete(entity);
        }

        public List<Country> GetAll()
        {
            return _countryDAL.GetAll();
        }

        public Country GetById(int? id)
        {
            return _countryDAL.Get(i => i.Id == id);
        }

        public void Update(Country entity)
        {
            _countryDAL.Update(entity);
        }
    }
}
