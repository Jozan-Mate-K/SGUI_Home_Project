using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Connectors
{
    public interface IRestService
    {
        List<T> Get<T>(string endpoint);
        T GetSingle<T>(string endpoint);
        T Get<T>(int id, string endpoint);
        void Post<T>(T item, string endpoint);
        void Delete(int id, string endpoint);
        void Put<T>(T item, string endpoint);
    }

}
