using Connectors;
using Models;
using SGUI_Home_Project.Commands;
using SGUI_Home_Project.Store;
using SGUI_Home_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SGUI_Home_Project.ViewModels
{
    internal class InstrumentAddNewViewModel : ViewModelBase<Instrument>
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public int? Year { get; set; }
        public ICommand AddCommand { get; }

        public instrumentTypeEnum Type { get; set; }
        public Array Types { get => Enum.GetValues(typeof(instrumentTypeEnum)); }

        public Manufacturer Manufacturer { get; set; }
        public ObservableCollection<Manufacturer> Manufacturers { get; set; }


        public Band Band { get; set; }
        public ObservableCollection<Band> Bands { get; set; }

        public IConnect<Instrument> Connect { get { return connect; } }


        public InstrumentAddNewViewModel(InstrumentNavigationStore navigationStore, InstrumentItemsStore itemsStore)
        {
            this.connect = new InstrumentConnect();
            Manufacturers = new ObservableCollection<Manufacturer>(new ManufacturerConnect().GetAll());
            Bands = new ObservableCollection<Band>(new BandConnect().GetAll());
            AddCommand = new AddNewInstrumentCommand(this, itemsStore, navigationStore);
        }
    }
}
