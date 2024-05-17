using SGUI_Home_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for BandAddNewView.xaml
    /// </summary>
    public partial class BandAddNewView : UserControl
    {
        BandAddNewViewModel viewModel;
        public BandAddNewView()
        {
            InitializeComponent();
        }
        private void changeEventHandler(object sender, EventArgs args)
        {
            if(DataContext == null)
            {
                Debug.WriteLine("no datacontext");
            }
            if(viewModel == null)
            {
                viewModel = (DataContext as BandAddNewViewModel);
            }
            viewModel.Name = name.Text;
            viewModel.Balance = int.Parse(Balance.Text) as int?;
            viewModel.OnPropertyChanged(nameof(BandAddNewViewModel));


        }

    }
}
