using Models;

namespace Connectors
{
    public class BandConnect : ConnectBase<Band>
    {
        public BandConnect()
        {
            this.endpoint = nameof(Band);
            this.restService = new RestService(Environment.URL);
        }

    }
}
