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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SGUI_Home_Project.Views
{
    /// <summary>
    /// Interaction logic for InstrumentEditView.xaml
    /// </summary>
    public partial class InstrumentEditView : UserControl
    {
        InstrumentEditViewModel viewModel;
        public InstrumentEditView()
        {
            InitializeComponent();
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(DataContext == null) 
            {
                Debug.WriteLine("No DataContext");
            }
            if(viewModel == null)
            {
                viewModel = (DataContext as InstrumentEditViewModel);
            }
        }
    }
}
