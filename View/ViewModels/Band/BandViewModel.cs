using Connectors;
using Models;
using SGUI_Home_Project.Commands;
using SGUI_Home_Project.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SGUI_Home_Project.ViewModels
{
    internal class BandViewModel : ViewModelBase<Band>
    {

        private BandMainWindow view;

        private readonly BandItemsStore itemStore = new BandItemsStore();
        private readonly BandNavigationStore navigationStore = new BandNavigationStore(); 
        private readonly BandSelectedItemStore selectedItemStore = new BandSelectedItemStore();
        
        public ViewModelBase<Band> CurrentView => navigationStore.CurrentView;

        public ICommand ChangeToAddNewCommand { get; }

        public BandViewModel(BandMainWindow view)
        {
            this.connect = new BandConnect();
            this.view = view;
            view.listView.DataContext = new BandListViewModel(view.listView, selectedItemStore, itemStore);

            navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            selectedItemStore.SelectedItemChanged += OnSelectedItemChanged;

            ChangeToAddNewCommand = new ChangeToAddNewBandCommand(navigationStore, itemStore);

        }

        private void OnSelectedItemChanged(Band obj)
        {
            navigationStore.CurrentView = new BandEditViewModel(obj, navigationStore, itemStore);
        }


        public void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentView));
        }



    }
}
