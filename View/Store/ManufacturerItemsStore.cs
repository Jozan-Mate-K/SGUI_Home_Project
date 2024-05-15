using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project.Store
{
    public class ManufacturerItemsStore
    {
        public event Action ManufacturersChanged;
        private ObservableCollection<Manufacturer> manufacturers;
        public ObservableCollection<Manufacturer> Manufacturers 
        { 
            get => manufacturers;
            set
            {
                manufacturers = value;
                OnManufacturersChanged();
            } 
        }

        private void OnManufacturersChanged()
        {
            ManufacturersChanged?.Invoke();
        }
    }
}
