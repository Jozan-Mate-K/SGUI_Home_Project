using System.Collections.Generic;

namespace Connectors
{
    public abstract class ConnectBase<T> : IConnect<T> where T : class
    {
        protected IRestService restService;
        protected string endpoint;

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
