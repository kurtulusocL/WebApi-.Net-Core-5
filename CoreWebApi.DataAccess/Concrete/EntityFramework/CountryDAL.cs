using CoreWebApi.Core.DataAccess.EntityFramework;
using CoreWebApi.DataAccess.Abstract;
using CoreWebApi.DataAccess.Concrete.EntityFramework.Context;
using CoreWebApi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebApi.DataAccess.Concrete.EntityFramework
{
    public class CountryDAL : EntityRepositoryBase<Country, ApplicationDbContext>, ICountryDAL
    {
        
    }
}
