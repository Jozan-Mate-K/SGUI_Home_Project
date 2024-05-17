using Models;
using SGUI_Home_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project.Commands
{
    internal class DeleteBandCommand : BaseCommand
    {
        private readonly BandItemsStore itemsStore;
        private readonly BandNavigationStore navigationStore;
        private readonly BandEditViewModel viewModel;

        public DeleteBandCommand(BandItemsStore itemsStore, BandNavigationStore navigationStore, BandEditViewModel viewModel)
        {
            this.itemsStore = itemsStore;
            this.navigationStore = navigationStore;
            this.viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            viewModel.Connect.Delete(viewModel.ID);
            itemsStore.Bands = new ObservableCollection<Band>(viewModel.Connect.GetAll());
            navigationStore.CurrentView = null;

        }
    }
}
