using System;
using SGUI_Home_Project.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Diagnostics;
using SGUI_Home_Project.Store;
using System.Collections.ObjectModel;

namespace SGUI_Home_Project.Commands
{
    internal class AddNewManufacturerCommand : BaseCommand
    {
        private readonly ManufacturerAddNewViewModel viewModel;
        public AddNewManufacturerCommand(ManufacturerAddNewViewModel viewModel) 
        { 
            this.viewModel = viewModel;
            this.viewModel.PropertyChanged += ViewModelPropertyChanged; 
        }
        private void ViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ManufacturerAddNewViewModel))
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
            viewModel.Connect.Post(new Manufacturer() { Name = viewModel.Name});
            viewModel.Reset();
        }
    }
}
