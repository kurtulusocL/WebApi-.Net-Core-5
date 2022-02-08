using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebApi.Core.CrossCuttingConcern.ApiHelper
{
    public class CountryApi
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:41869");
            return client;
        }
    }
}
