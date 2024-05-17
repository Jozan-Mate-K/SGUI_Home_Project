using Connectors;
using Models;
using SGUI_Home_Project.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SGUI_Home_Project.ViewModels
{
    internal class InstrumentEditViewModel: ViewModelBase<Instrument>
    {
        private Instrument instrument;

        public int ID => instrument.Id;
        public string Name => instrument.Name;
        public string Color => instrument.Color;
        public string Description => instrument.Description;
        public instrumentTypeEnum Type => instrument.Type;
        public string Manufacturer { get; }

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
        public IConnect<Instrument> Connect
        {
            get => connect;
        }
        public InstrumentEditViewModel(Instrument instrument,InstrumentNavigationStore navigationStore, InstrumentItemsStore itemsStore)
        {
            this.connect = new InstrumentConnect();
            this.instrument = instrument;
            Manufacturer = new ManufacturerConnect().Get(instrument.ManufacturerId)?.Name;
        }
    }
}
