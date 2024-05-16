using Models;
using SGUI_Home_Project.ViewModels;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for InstrumentListWindow.xaml
    /// </summary>
    public partial class InstrumentListView : UserControl
    {
        InstrumentListViewModel viewModel;
        public InstrumentListView()
        {
            InitializeComponent();
            viewModel = new InstrumentListViewModel(this);
            DataContext = viewModel;

        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstView.SelectedItem != null)
            {
                //(DataContext as InstrumentListViewModel).SelectedItemStore.SelectedItem = lstView.SelectedItem as Manufacturer;

            }
        }
    }
}
