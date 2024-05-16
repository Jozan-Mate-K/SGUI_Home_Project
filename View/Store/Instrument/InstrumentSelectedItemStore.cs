using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project.Store
{
    internal class InstrumentSelectedItemStore
    {
        public event Action<Instrument> SelectedItemChanged;
        private Instrument selectedItem;
        public Instrument SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                OnSelectedItemChanged(value);
            }
        }

        private void OnSelectedItemChanged(Instrument instrument)
        {
            SelectedItemChanged?.Invoke(instrument);
        }
    }
}
