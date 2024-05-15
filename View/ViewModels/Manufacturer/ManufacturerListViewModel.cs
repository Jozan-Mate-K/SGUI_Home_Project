using Connectors;
using Models;
using SGUI_Home_Project.Commands;
using SGUI_Home_Project.Store;
using SGUI_Home_Project.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SGUI_Home_Project.ViewModels
{
    public class ManufacturerListViewModel:ViewModelBase<Manufacturer>
    {
        private ManufacturerListView view;
        private Manufacturer selectedItem => view.lstView.SelectedItem as Manufacturer;
        private readonly ManufacturerSelectedItemStore selectedItemStore;
        private readonly ManufacturerItemsStore itemsStore;

        public ManufacturerSelectedItemStore SelectedItemStore => selectedItemStore;
        public ManufacturerListViewModel(ManufacturerListView view, ManufacturerSelectedItemStore selectedItemStore, ManufacturerItemsStore itemsStore)
        {
            connect = new ManufacturerConnect();
            this.view = view;

            this.itemsStore = itemsStore;
            this.itemsStore.ManufacturersChanged += OnManufacturersChanged;
            this.itemsStore.Manufacturers = new ObservableCollection<Manufacturer>(connect.GetAll());
            this.selectedItemStore = selectedItemStore;
        }

        private void OnManufacturersChanged()
        {
            if(itemsStore.Manufacturers != null)
            {
                view.lstView.ItemsSource = itemsStore.Manufacturers;

            }
            OnPropertyChanged(nameof(ManufacturerListViewModel));
        }
    }
}
