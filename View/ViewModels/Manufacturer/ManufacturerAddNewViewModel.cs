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
        public string Name { get; set; }
        public ICommand AddCommand { get; }
        public IConnect<Manufacturer> Connect { get { return connect; } }
        private readonly ManufacturerAddNewView view;

        public ManufacturerAddNewViewModel()
        {
            Name = String.Empty;
            connect = new ManufacturerConnect();
            AddCommand = new AddNewManufacturerCommand(this);
        }

        internal void Reset()
        {
            Name = string.Empty;
        }
    }
}
