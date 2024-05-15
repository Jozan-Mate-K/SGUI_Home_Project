using SGUI_Home_Project.Store;
using SGUI_Home_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project.Commands
{
    internal class ChangeToAddNewManufacturerCommand: BaseCommand
    {
        private readonly ManufacturerNavigationStore navigationStore;
        public ChangeToAddNewManufacturerCommand( ManufacturerNavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            navigationStore.CurrentView = null;
            navigationStore.CurrentView = new ManufacturerAddNewViewModel();
        }
    }
}
