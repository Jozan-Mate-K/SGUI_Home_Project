using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project.Store
{
    internal class InstrumentItemsStore
    {
        public event Action InstrumentsChanged;
        private ObservableCollection<Instrument> instruments;
        public ObservableCollection<Instrument> Instruments
        {
            get => instruments;
            set
            {
                instruments = value;
                OnInstrumentsChanged();
            }
        }

        private void OnInstrumentsChanged()
        {
            InstrumentsChanged?.Invoke();
        }
    }
}
