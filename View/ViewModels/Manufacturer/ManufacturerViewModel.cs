using Connectors;
using Models;
using SGUI_Home_Project.Commands;
using SGUI_Home_Project.Store;
using SGUI_Home_Project.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;


namespace SGUI_Home_Project.ViewModels
{
    internal class ManufacturerViewModel: ViewModelBase<Manufacturer>
    {
        private ManufacturerMainWindow view;

        private readonly ManufacturerSelectedItemStore selectedItemStore = new ManufacturerSelectedItemStore();
        private readonly ManufacturerItemsStore itemsStore = new ManufacturerItemsStore();
        private readonly ManufacturerNavigationStore navigationStore = new ManufacturerNavigationStore();
        public ManufacturerNavigationStore ManufacturerNavigationStore { get { return navigationStore; } }

        public ViewModelBase<Manufacturer> CurrentView => navigationStore.CurrentView;
        public ICommand ChangeToAddNewCommand { get; }

        public ManufacturerViewModel(ManufacturerMainWindow view)
        {
            this.connect = new ManufacturerConnect();
            this.view = view;
            view.listView.DataContext = new ManufacturerListViewModel(view.listView, selectedItemStore, itemsStore);

            navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            selectedItemStore.SelectedItemChanged += OnSelectedItemChanged;

            ChangeToAddNewCommand = new ChangeToAddNewManufacturerCommand(navigationStore, itemsStore);
        }

        private void OnSelectedItemChanged(Manufacturer obj)
        {
            navigationStore.CurrentView = new ManufacturerEditViewModel(obj, navigationStore, itemsStore);
        }

        public void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentView));
        }
        
    }
}
