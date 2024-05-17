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
    internal class EditInstrumentCommand: BaseCommand
    {
        private readonly InstrumentEditViewModel viewModel;
        private readonly InstrumentItemsStore itemsStore;
        private readonly InstrumentNavigationStore navigationStore;

        public EditInstrumentCommand(InstrumentEditViewModel viewModel, InstrumentItemsStore itemsStore, InstrumentNavigationStore navigationStore)
        {
            this.viewModel = viewModel;
            this.itemsStore = itemsStore;
            this.navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            Instrument dto;
            if(viewModel.Band == null)
            {
                dto = new Instrument()
                {
                    Id = viewModel.ID,
                    Name = viewModel.Name,
                    Color = viewModel.Color,
                    Description = viewModel.Description,
                    Type = viewModel.Type,
                    Manufacturer = viewModel.Manufacturer,
                    ManufacturerId = viewModel.Manufacturer.Id,

                };
            }
            else if (viewModel.Manufacturer == null)
            {
                dto = new Instrument()
                {
                    Id = viewModel.ID,
                    Name = viewModel.Name,
                    Color = viewModel.Color,
                    Description = viewModel.Description,
                    Type = viewModel.Type,
                    Band = viewModel.Band,
                    BandId = viewModel.Band.Id
                };
            }
            else if(viewModel.Manufacturer == null && viewModel.Band == null)
            {
                dto = new Instrument()
                {
                    Id = viewModel.ID,
                    Name = viewModel.Name,
                    Color = viewModel.Color,
                    Description = viewModel.Description,
                    Type = viewModel.Type,
                };
            }
            else
            {
                dto = new Instrument()
                {
                    Id = viewModel.ID,
                    Name = viewModel.Name,
                    Color = viewModel.Color,
                    Description = viewModel.Description,
                    Type = viewModel.Type,
                    Manufacturer = viewModel.Manufacturer,
                    ManufacturerId = viewModel.Manufacturer.Id,
                    Band = viewModel.Band,
                    BandId = viewModel.Band.Id
                };
            }
            viewModel.Connect.Put(dto);
            itemsStore.Instruments = new ObservableCollection<Instrument>(viewModel.Connect.GetAll());
            navigationStore.CurrentView = new InstrumentEditViewModel(itemsStore.Instruments.Single(x => x.Name == viewModel.Name), navigationStore, itemsStore);

        }
    }
}
