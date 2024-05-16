using Connectors;
using Models;
using SGUI_Home_Project.Store;
using SGUI_Home_Project.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;

namespace SGUI_Home_Project.ViewModels
{
    internal class InstrumentListViewModel: ViewModelBase<Instrument>
    {
        private InstrumentListView view;
        private readonly InstrumentItemsStore itemsStore;
        private readonly InstrumentSelectedItemStore selectedItemStore;

        public InstrumentSelectedItemStore SelectedItemStore { get { return selectedItemStore; } }

        public InstrumentListViewModel(InstrumentListView view, InstrumentSelectedItemStore selectedItemStore, InstrumentItemsStore itemsStore)
        {
            connect = new InstrumentConnect();
            this.view = view;

            this.itemsStore = itemsStore;
            this.itemsStore.InstrumentsChanged += OnInstrumentChanged;
            this.itemsStore.Instruments = new ObservableCollection<Instrument>(connect.GetAll());
            this.selectedItemStore = selectedItemStore;
        }

        private void OnInstrumentChanged()
        {
            if(itemsStore.Instruments != null)
            {
                view.lstView.ItemsSource = itemsStore.Instruments;
            }
            OnPropertyChanged(nameof(InstrumentListViewModel));
        }
    }
}
