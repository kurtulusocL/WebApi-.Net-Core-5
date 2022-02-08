using CoreWebApi.Core.Entities.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebApi.Entities.Concrete
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
    }
}
