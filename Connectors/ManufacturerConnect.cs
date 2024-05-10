using Models;

namespace Connectors
{
    public class ManufacturerConnect: ConnectBase<Manufacturer>
    {
        public ManufacturerConnect()
        {
            this.endpoint = nameof(Manufacturer);
            this.restService = new RestService(Environment.URL);
        }

    }
}
