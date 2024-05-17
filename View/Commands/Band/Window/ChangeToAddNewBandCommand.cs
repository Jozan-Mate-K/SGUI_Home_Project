using SGUI_Home_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project.Commands
{
    internal class ChangeToAddNewBandCommand :BaseCommand
    {
        private readonly BandNavigationStore navigationStore;
        private readonly BandItemsStore itemStore;

        public ChangeToAddNewBandCommand(BandNavigationStore navigationStore, BandItemsStore itemStore)
        {
            this.navigationStore = navigationStore;
            this.itemStore = itemStore;
        }

        public override void Execute(object parameter)
        {
            navigationStore.CurrentView = new BandAddNewViewModel(navigationStore, itemStore);
        }
    }
}
