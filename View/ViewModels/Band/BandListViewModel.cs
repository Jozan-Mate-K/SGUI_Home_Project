using Connectors;
using Models;
using SGUI_Home_Project.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project.ViewModels
{
    public class BandListViewModel : ViewModelBase<Band>
    {
        private BandListView view;
        private Band selectedItem => view.lstView.SelectedItem as Band;
        private readonly BandSelectedItemStore selectedItemStore;
        private readonly BandItemsStore itemStore;

        public BandSelectedItemStore SelectedItemStore => selectedItemStore;
        public BandListViewModel(BandListView view, BandSelectedItemStore selectedItemStore, BandItemsStore itemStore)
        {
            connect = new BandConnect();
            this.view = view;

            this.itemStore = itemStore;
            this.itemStore.BandChanged += OnBandsChanged;
            this.itemStore.Bands = new ObservableCollection<Band>(connect.GetAll());
            this.selectedItemStore = selectedItemStore;
        }

        private void OnBandsChanged()
        {
            if(itemStore.Bands != null)
            {
                view.lstView.ItemsSource = itemStore.Bands;
            }
            OnPropertyChanged(nameof(BandListViewModel));
        }


    }
}
