using Models;
using SGUI_Home_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project.Store
{
    internal class InstrumentNavigationStore
    {
        public event Action CurrentViewModelChanged;
        private ViewModelBase<Instrument> currentViewModel;
        public ViewModelBase<Instrument> CurrentView
        {
            get => currentViewModel;
            set
            {
                currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
