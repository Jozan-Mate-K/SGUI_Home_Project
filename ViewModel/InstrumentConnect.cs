using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    internal class InstrumentConnect : IConnect<Instrument>
    {
        private RestService restService = new RestService(Environment.URL);
        private readonly string endpoint = "Instrument";

        public Instrument Get(int ID)
        {
            return restService.Get<Instrument>(ID, endpoint);
        }
        public List<Instrument> GetAll()
        {
            return restService.Get<Instrument>(endpoint);
        }
        public void Put(Instrument item)
        {
            restService.Put<Instrument>(item, endpoint);
        }
        public void Post(Instrument item)
        {
            restService.Post<Instrument>(item, endpoint);
        }
        public void Delete(int ID)
        {
            restService.Delete(ID, endpoint);
        }
    }
}
