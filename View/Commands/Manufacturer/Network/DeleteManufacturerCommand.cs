using Models;
using SGUI_Home_Project.Store;
using SGUI_Home_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project.Commands
{
    internal class DeleteManufacturerCommand : BaseCommand
    {
        private readonly ManufacturerEditViewModel viewModel;
        private readonly ManufacturerNavigationStore navigationStore;
        private readonly ManufacturerItemsStore itemsStore;

        public DeleteManufacturerCommand(ManufacturerEditViewModel viewModel, ManufacturerNavigationStore navigationStore, ManufacturerItemsStore itemsStore)
        {
            this.viewModel = viewModel;
            this.navigationStore = navigationStore;
            this.itemsStore = itemsStore;
        }

        public override void Execute(object parameter)
        {
            viewModel.Connect.Delete(viewModel.ID);
            itemsStore.Manufacturers = new ObservableCollection<Manufacturer>(viewModel.Connect.GetAll());
            navigationStore.CurrentView = null;
        }
    }
}
