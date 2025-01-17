﻿using SGUI_Home_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SGUI_Home_Project.Views
{
    /// <summary>
    /// Interaction logic for ManufacturerEditView.xaml
    /// </summary>
    public partial class ManufacturerEditView : UserControl
    {
        ManufacturerEditViewModel viewModel;
        public ManufacturerEditView()
        {
            InitializeComponent();
            //Debug.WriteLine(DataContext.ToString());
            viewModel = (DataContext as ManufacturerEditViewModel);
        }
        private void changeEventHandler(object sender, EventArgs args)
        {
            if(DataContext == null)
            {
                Debug.WriteLine("No DataContext"); //Somehow this is not an issue
            }
            if(viewModel == null)
            {
                viewModel = (DataContext as ManufacturerEditViewModel);
            }
            viewModel.Name = name.Text;
            viewModel.OnPropertyChanged(nameof(ManufacturerEditViewModel));
        }
    }
}
