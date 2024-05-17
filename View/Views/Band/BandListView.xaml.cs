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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SGUI_Home_Project.Views
{
    /// <summary>
    /// Interaction logic for BandListWindow.xaml
    /// </summary>
    public partial class BandListView : UserControl
    {
        public BandListView()
        {
            InitializeComponent();
        }


        private void SelectionChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (lstView.SelectedItem != null)
            {
                (DataContext as BandListViewModel).SelectedItemStore.SelectedItem = lstView.SelectedItem as Band;
            }
        }

    }
}
