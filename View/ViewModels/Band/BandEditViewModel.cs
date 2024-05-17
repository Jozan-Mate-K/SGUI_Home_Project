using Connectors;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SGUI_Home_Project.ViewModels
{
    public class BandEditViewModel :ViewModelBase<Band>
    {
        private Band Band;

        public int ID => Band.Id;
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        private int? balance;
        public int? Balance
        {
            get => balance;
            set => balance = value;
        }


        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public IConnect<Band> Connect
        {
            get => Connect;
        }

        public BandEditViewModel(Band band, BandNavigationStore navigationStore, BandItemsStore itemsStore)
        {
            this.connect = new BandConnect();
            this.Band = band;
            name = band.Name;
            balance = band.Balance;
            
        }


    }
}
