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
    internal class EditManufacturerCommand : BaseCommand
    {
        private readonly ManufacturerEditViewModel viewModel;
        private readonly ManufacturerItemsStore itemsStore;
        public EditManufacturerCommand(ManufacturerEditViewModel viewModel, ManufacturerItemsStore itemsStore) 
        { 
            this.itemsStore = itemsStore;
            this.viewModel = viewModel;
            this.viewModel.PropertyChanged += ViewModelPropertyChanged; 
        }
        private void ViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ManufacturerEditViewModel))
            {
                OnCanExecuteChanged();
            }
        }
        public override bool CanExecute(object parameter)
        {
            return base.CanExecute(parameter) && viewModel.Name != String.Empty;
        }
        public override void Execute(object parameter)
        {
            viewModel.Connect.Put(new Manufacturer() {Id= viewModel.ID, Name = viewModel.Name});
            itemsStore.Manufacturers = new ObservableCollection<Manufacturer>(viewModel.Connect.GetAll());
        }
    }
}
