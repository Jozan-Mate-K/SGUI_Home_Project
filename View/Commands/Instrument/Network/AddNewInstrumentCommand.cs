using Models;
using SGUI_Home_Project.Store;
using SGUI_Home_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project.Commands
{
    internal class AddNewInstrumentCommand: BaseCommand
    {
        private readonly InstrumentAddNewViewModel viewModel;
        private readonly InstrumentItemsStore itemsStore;
        private readonly InstrumentNavigationStore navigationStore;

        public AddNewInstrumentCommand(InstrumentAddNewViewModel viewModel, InstrumentItemsStore itemsStore, InstrumentNavigationStore navigationStore)
        {
            this.viewModel = viewModel;
            this.itemsStore = itemsStore;
            this.navigationStore = navigationStore;
            this.viewModel.PropertyChanged += ViewModelPropertyChanged;
        }

        private void ViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(InstrumentAddNewViewModel))
            {
                OnCanExecuteChanged();
            }
        }
        public override bool CanExecute(object parameter)
        {
            return base.CanExecute(parameter) && viewModel.Name != String.Empty && viewModel.Manufacturer != null;
        }

        public override void Execute(object parameter)
        {
            Instrument dto;
            if(viewModel.Band == null)
            {
                dto = new Instrument()
                {
                    Name = viewModel.Name,
                    Type = viewModel.Type,
                    Manufacturer = viewModel.Manufacturer,
                    ManufacturerId = viewModel.Manufacturer.Id,

                };
            }
            else
            {
                dto = new Instrument()
                {
                    Name = viewModel.Name,
                    Type = viewModel.Type,
                    Manufacturer = viewModel.Manufacturer,
                    ManufacturerId = viewModel.Manufacturer.Id,
                    Band = viewModel.Band,
                    BandId = viewModel.Band.Id
                };
            }
            if(viewModel.Description != null)
            {
                dto.Description = viewModel.Description;
            }
            if(viewModel.Color != null)
            {
                dto.Color = viewModel.Color;
            }
            viewModel.Connect.Post(dto);
            itemsStore.Instruments = new ObservableCollection<Instrument>(viewModel.Connect.GetAll());
            navigationStore.CurrentView = new InstrumentEditViewModel(itemsStore.Instruments.Single(x => x.Name == viewModel.Name), navigationStore, itemsStore);
        }
    }
}
