using Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Connectors
{
    public class ConnectBase<T> : IConnect<T> where T : class
    {
        private RestService restService = new RestService(Environment.URL);
        private readonly string endpoint = nameof(T);

        public T Get(int ID)
        {
            return restService.Get<T>(ID, endpoint);
        }
        public List<T> GetAll()
        {
            return restService.Get<T>(endpoint);
        }
        public void Put(T item)
        {
            restService.Put<T>(item, endpoint);
        }
        public void Post(T item)
        {
            restService.Post<T>(item, endpoint);
        }
        public void Delete(int ID)
        {
            restService.Delete(ID, endpoint);
        }
    }
}
