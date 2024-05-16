using System;
using SGUI_Home_Project.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Diagnostics;
using SGUI_Home_Project.Store;
using System.Collections.ObjectModel;

namespace SGUI_Home_Project.Commands
{
    internal class AddNewManufacturerCommand : BaseCommand
    {
        private readonly ManufacturerAddNewViewModel viewModel;
        private readonly ManufacturerItemsStore itemsStore;
        private readonly ManufacturerNavigationStore navigationStore;


        public AddNewManufacturerCommand(ManufacturerAddNewViewModel viewModel, ManufacturerNavigationStore navigationStore, ManufacturerItemsStore itemsStore) 
        { 
            this.viewModel = viewModel;
            this.viewModel.PropertyChanged += ViewModelPropertyChanged;
            this.navigationStore = navigationStore;
            this.itemsStore = itemsStore;
        }
        private void ViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ManufacturerAddNewViewModel))
            {
                OnCanExecuteChanged();
            }
        }
        public override bool CanExecute(object parameter)
        {
            return base.CanExecute(parameter) && viewModel.Name != String.Empty && itemsStore.Manufacturers.SingleOrDefault(x=> x.Name == viewModel.Name) == null;
        }
        public override void Execute(object parameter)
        {
            viewModel.Connect.Post(new Manufacturer() { Name = viewModel.Name});
            itemsStore.Manufacturers = new ObservableCollection<Manufacturer>(viewModel.Connect.GetAll());
            navigationStore.CurrentView = new ManufacturerEditViewModel(itemsStore.Manufacturers.Single(x => x.Name == viewModel.Name), navigationStore, itemsStore);

        }
    }
}
