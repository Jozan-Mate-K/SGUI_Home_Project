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
    internal class DeleteInstrumentCommand:BaseCommand
    {
        private readonly InstrumentEditViewModel viewModel;
        private readonly InstrumentNavigationStore navigationStore;
        private readonly InstrumentItemsStore itemsStore;

        public DeleteInstrumentCommand(InstrumentEditViewModel viewModel, InstrumentNavigationStore navigationStore, InstrumentItemsStore itemsStore)
        {
            this.viewModel = viewModel;
            this.navigationStore = navigationStore;
            this.itemsStore = itemsStore;
        }

        public override void Execute(object parameter)
        {
            viewModel.Connect.Delete(viewModel.ID);
            itemsStore.Instruments = new ObservableCollection<Instrument>(viewModel.Connect.GetAll());
            navigationStore.CurrentView = null;
        }
    }
}
