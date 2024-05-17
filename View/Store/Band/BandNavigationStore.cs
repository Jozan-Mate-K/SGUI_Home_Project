using Models;
using SGUI_Home_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project
{
    public class BandNavigationStore
    {
        public event Action CurrentViewModelChanged;
        private ViewModelBase<Band> currentViewModel;
        public ViewModelBase<Band> CurrentView
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
