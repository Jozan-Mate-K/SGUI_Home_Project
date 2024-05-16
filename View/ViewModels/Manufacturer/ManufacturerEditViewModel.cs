using Connectors;
using Models;
using SGUI_Home_Project.Commands;
using SGUI_Home_Project.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SGUI_Home_Project.ViewModels
{
    internal class ManufacturerEditViewModel: ViewModelBase<Manufacturer>
    {
        private Manufacturer manufacturer;

        public int ID => manufacturer.Id;
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
        public IConnect<Manufacturer> Connect
        {
            get => connect;
        }

        public ManufacturerEditViewModel(Manufacturer manufacturer, ManufacturerNavigationStore navigationStore, ManufacturerItemsStore itemsStore)
        {
            this.connect = new ManufacturerConnect();
            this.manufacturer = manufacturer;
            name = manufacturer.Name;
            EditCommand = new EditManufacturerCommand(this, itemsStore);
            DeleteCommand = new DeleteManufacturerCommand(this, navigationStore, itemsStore);
        }

    }
}
