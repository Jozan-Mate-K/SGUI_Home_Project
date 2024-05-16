using Connectors;
using Models;
using SGUI_Home_Project.Commands;
using SGUI_Home_Project.Store;
using SGUI_Home_Project.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SGUI_Home_Project.ViewModels
{
    internal class ManufacturerAddNewViewModel: ViewModelBase<Manufacturer>
    {
        private string name;
        public string Name 
        { 
            get => name; 
            set => name = value; 
        }


        public ICommand AddCommand { get; }
        public IConnect<Manufacturer> Connect { get { return connect; } }
        private readonly ManufacturerAddNewView view;

        public ManufacturerAddNewViewModel(ManufacturerNavigationStore navigationStore, ManufacturerItemsStore itemsStore)
        {
            Name = String.Empty;
            connect = new ManufacturerConnect();
            AddCommand = new AddNewManufacturerCommand(this, navigationStore, itemsStore);
        }

        internal void Reset()
        {
            Name = string.Empty;
            view.name.Clear();
        }
    }
}
