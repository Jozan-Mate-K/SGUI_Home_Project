using Models;
using SGUI_Home_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace SGUI_Home_Project.Commands
{
    internal class AddNewBandCommand : BaseCommand
    {
        private readonly BandAddNewViewModel viewModel;
        private readonly BandItemsStore itemsStore;
        private readonly BandNavigationStore navigationStore;

        public AddNewBandCommand(BandAddNewViewModel viewModel, BandNavigationStore navigationStore, BandItemsStore itemsStore)
        {
            this.viewModel = viewModel;
            this.navigationStore = navigationStore;
            this.itemsStore = itemsStore;
            this.viewModel.PropertyChanged += ViewModelPropertyChanged;

        }

        private void ViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(BandAddNewViewModel))
            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return base.CanExecute(parameter) && 
                viewModel.Name != String.Empty && 
                itemsStore.Bands.SingleOrDefault(x=> x.Name == viewModel.Name) == null;

        }

        public override void Execute(object parameter)
        {
            viewModel.Connect.Post(new Band() { Name = viewModel.Name, Balance = viewModel.Balance });
            itemsStore.Bands = new ObservableCollection<Band>(viewModel.Connect.GetAll());
            navigationStore.CurrentView = new BandEditViewModel(
                itemsStore.Bands.Single(x => x.Name == viewModel.Name),
                navigationStore,
                itemsStore
            );

        }


    }
}
