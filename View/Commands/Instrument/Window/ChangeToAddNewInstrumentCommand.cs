using SGUI_Home_Project.Store;
using SGUI_Home_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project.Commands
{
    internal class ChangeToAddNewInstrumentCommand : BaseCommand
    {
        private readonly InstrumentNavigationStore navigationStore;
        private readonly InstrumentItemsStore itemsStore;

        public ChangeToAddNewInstrumentCommand(InstrumentNavigationStore navigationStore, InstrumentItemsStore itemsStore)
        {
            this.navigationStore = navigationStore;
            this.itemsStore = itemsStore;
        }

        public override void Execute(object parameter)
        {
            navigationStore.CurrentView = new InstrumentAddNewViewModel(navigationStore, itemsStore);
        }
    }
}
