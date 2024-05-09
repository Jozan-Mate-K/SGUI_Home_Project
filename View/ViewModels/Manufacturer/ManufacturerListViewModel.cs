using Connectors;
using Models;
using SGUI_Home_Project.ViewModel;
using SGUI_Home_Project.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project.ViewModels
{
    public class ManufacturerListViewModel:ViewModelBase<Manufacturer>
    {
        private ManufacturerListView view;
        private IConnect<Manufacturer> connect;

        public ManufacturerListViewModel(ManufacturerListView view)
        {
            connect = new ManufacturerConnect();
            this.view = view;
        }

    }
}
