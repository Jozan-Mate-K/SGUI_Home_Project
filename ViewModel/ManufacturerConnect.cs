using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    internal class ManufacturerConnect: IConnect<Manufacturer>
    {
        private RestService restService = new RestService(Environment.URL);
        private readonly string endpoint = "Manufacturer";

        public Manufacturer Get(int ID)
        {
            return restService.Get<Manufacturer>(ID, endpoint);
        }
        public List<Manufacturer> GetAll()
        {
            return restService.Get<Manufacturer>(endpoint);
        }
        public void Put(Manufacturer item)
        {
            restService.Put<Manufacturer>(item, endpoint);
        }
        public void Post(Manufacturer item)
        {
            restService.Post<Manufacturer>(item, endpoint); 
        }
        public void Delete(int ID)
        {
            restService.Delete(ID, endpoint);
        }


    }
}
