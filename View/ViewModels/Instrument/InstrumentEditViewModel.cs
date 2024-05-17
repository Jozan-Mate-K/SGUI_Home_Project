using Connectors;
using Models;
using SGUI_Home_Project.Commands;
using SGUI_Home_Project.Store;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
        public IConnect<Instrument> Connect
        {
            get => connect;
        }

        public Band Band { get; set; }

        public ObservableCollection<Band> Bands { get; }

        public Manufacturer Manufacturer { get; set; }
        public ObservableCollection<Manufacturer> Manufacturers { get; }

        public string CurrentBandName { get=> new BandConnect().Get(instrument.BandId)?.Name; }
        public string CurrentManufacturerName {  get=> new ManufacturerConnect().Get(instrument.ManufacturerId)?.Name;  }

        public InstrumentEditViewModel(Instrument instrument,InstrumentNavigationStore navigationStore, InstrumentItemsStore itemsStore)
        {
            this.connect = new InstrumentConnect();
            this.instrument = instrument;
            Bands = new ObservableCollection<Band>(new BandConnect().GetAll());
            Manufacturers = new ObservableCollection<Manufacturer>(new ManufacturerConnect().GetAll());
            Band = new BandConnect().Get(instrument.BandId);
            Manufacturer = new ManufacturerConnect().Get(instrument.ManufacturerId);
            EditCommand = new EditInstrumentCommand(this,itemsStore, navigationStore);
            DeleteCommand = new DeleteInstrumentCommand(this, navigationStore, itemsStore);
        }
    }
}
