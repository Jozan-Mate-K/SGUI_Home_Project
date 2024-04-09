using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    internal class BandConnect : IConnect<Band>
    {
        private RestService restService = new RestService(Environment.URL);
        private readonly string endpoint = "Band";

        public Band Get(int ID)
        {
            return restService.Get<Band>(ID, endpoint);
        }
        public List<Band> GetAll()
        {
            return restService.Get<Band>(endpoint);
        }
        public void Put(Band item)
        {
            restService.Put<Band>(item, endpoint);
        }
        public void Post(Band item)
        {
            restService.Post<Band>(item, endpoint);
        }
        public void Delete(int ID)
        {
            restService.Delete(ID, endpoint);
        }
    }
}
