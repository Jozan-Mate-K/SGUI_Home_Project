using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project
{
    public class BandSelectedItemStore
    {
        public event Action<Band> SelectedItemChanged;
        private Band selectedItem;
        public Band SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                OnSelectedItemChanged(value);

            }
        }

        private void OnSelectedItemChanged(Band Band)
        {
            SelectedItemChanged?.Invoke(Band);
        }

    }
}
