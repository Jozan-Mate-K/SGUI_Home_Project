using Connectors;
using Models;
using SGUI_Home_Project.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace SGUI_Home_Project.ViewModels
{
    internal class BandAddNewViewModel : ViewModelBase<Band>
    {
        public string name { get; set; }
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

        public ICommand AddCommand { get; }

        public IConnect<Band> Connect { get { return connect; } }
        private readonly BandAddNewViewModel view;


        public BandAddNewViewModel(BandNavigationStore navigationStore, BandItemsStore itemsStore)
        {
            Name = String.Empty;
            Balance = null;
            connect = new BandConnect();
            AddCommand = new AddNewBandCommand(this, navigationStore, itemsStore);
        }

        internal void reset()
        {
            Name = String.Empty;
            //views.name.clear();
        }
    }
}
