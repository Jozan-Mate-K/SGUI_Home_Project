using Models;
using SGUI_Home_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project.Commands
{
    internal class EditBandCommand : BaseCommand
    {
        private readonly BandEditViewModel viewModel;
        private readonly BandItemsStore itemsStore;

        public EditBandCommand(BandEditViewModel viewModel, BandItemsStore itemsStore)
        {
            this.viewModel = viewModel;
            this.itemsStore = itemsStore;
            this.viewModel.PropertyChanged += ViewModelPropertyChanged;

        }


        private void ViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(BandEditViewModel))
            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return base.CanExecute(parameter) && viewModel.Name != String.Empty;

        }

        public override void Execute(object parameter)
        {
            viewModel.Connect.Put(new Band() { Id = viewModel.ID, Name = viewModel.Name, Balance = viewModel.Balance });
            itemsStore.Bands = new System.Collections.ObjectModel.ObservableCollection<Band>(viewModel.Connect.GetAll());
        }
    }
}
