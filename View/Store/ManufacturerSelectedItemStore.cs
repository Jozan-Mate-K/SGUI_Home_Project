using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project.Store
{
    public class ManufacturerSelectedItemStore
    {
        public event Action<Manufacturer> SelectedItemChanged;
        private Manufacturer selectedItem;
        public Manufacturer SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                OnSelectedItemChanged(value);
            }
        }

        private void OnSelectedItemChanged(Manufacturer manufacturer)
        {
            SelectedItemChanged?.Invoke(manufacturer);
        }
    }
}
