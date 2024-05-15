using Models;
using SGUI_Home_Project.ViewModels;
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
using System.Windows.Shapes;

namespace SGUI_Home_Project.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ManufacturerAddNewView : UserControl
    {
        ManufacturerAddNewViewModel viewModel;
        public ManufacturerAddNewView()
        {
            InitializeComponent();
            viewModel = (DataContext as ManufacturerAddNewViewModel); //WHYYYYYYYYYYYYYYYYYYYY
            //viewModel = new ManufacturerAddNewViewModel();
            //DataContext = viewModel;
            name.Text = String.Empty;
        }
        private void changeEventHandler(object sender, EventArgs args)
        {
            if (viewModel != null)
            {
                viewModel.Name = name.Text;
                viewModel.OnPropertyChanged(nameof(ManufacturerAddNewViewModel));
            }

        }

        private void Click(object sender, RoutedEventArgs e)
        {

            name.Text = String.Empty;

        }
    }
}
