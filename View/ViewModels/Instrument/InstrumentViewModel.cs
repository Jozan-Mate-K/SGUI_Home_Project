using Connectors;
using Models;
using SGUI_Home_Project.Commands;
using SGUI_Home_Project.Store;
using SGUI_Home_Project.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SGUI_Home_Project.ViewModels
{
    internal class InstrumentViewModel:ViewModelBase<Instrument>
    {
        private readonly InstrumentItemsStore itemsStore = new InstrumentItemsStore();
        private readonly InstrumentNavigationStore navigationStore = new InstrumentNavigationStore();
        private readonly InstrumentSelectedItemStore selectedItemStore = new InstrumentSelectedItemStore();

        public ViewModelBase<Instrument> CurrentView => navigationStore.CurrentView;
        public ICommand ChangeToAddNewCommand { get; }

        public InstrumentViewModel(InstrumentMainWindow view)
        {
            this.connect = new InstrumentConnect();
            view.listView.DataContext = new InstrumentListViewModel(view.listView, selectedItemStore, itemsStore);

            navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            selectedItemStore.SelectedItemChanged += OnSelectedItemChanged;

            ChangeToAddNewCommand = new ChangeToAddNewInstrumentCommand(navigationStore, itemsStore);
        }

        private void OnSelectedItemChanged(Instrument instrument)
        {
            navigationStore.CurrentView = new InstrumentEditViewModel();
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentView));
        }
    }
}
