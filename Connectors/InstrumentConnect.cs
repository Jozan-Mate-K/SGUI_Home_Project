using Models;

namespace Connectors
{
    public class InstrumentConnect : ConnectBase<Instrument>
    {
        public InstrumentConnect()
        {
            this.endpoint = nameof(Instrument);
            this.restService = new RestService(Environment.URL);
        }

    }
}
