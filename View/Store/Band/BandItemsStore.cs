using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project
{
    public class BandItemsStore
    {
        public event Action BandChanged;
        private ObservableCollection<Band> bands;
        public ObservableCollection<Band> Bands
        {
            get => bands;
            set
            {
                bands = value;
                OnBandChanged();
            }
        }
        private void OnBandChanged()
        {
            BandChanged?.Invoke();           
        }




    }
}
