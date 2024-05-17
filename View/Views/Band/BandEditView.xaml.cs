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
    /// Interaction logic for BandEditView.xaml
    /// </summary>
    public partial class BandEditView : UserControl
    {
        BandEditViewModel viewModel;
        public BandEditView()
        {
            InitializeComponent();
            viewModel = (DataContext as BandEditViewModel);

        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (DataContext == null)
            {
                Debug.WriteLine("No DataContext"); //Somehow this is not an issue
            }
            if (viewModel == null)
            {
                viewModel = (DataContext as BandEditViewModel);
            }
            //viewModel.Name = name.Text;
            viewModel.Balance = balanceParse(Balance.Text);
            viewModel.OnPropertyChanged(nameof(BandEditViewModel));
        }

        private int? balanceParse(string input)
        {
            
            try
            {
                return int.Parse(input) as int?;

            }
            catch (Exception e)
            {
                if(Balance.Text.Length > 1)
                {
                    Balance.Text = Balance.Text.Remove(Balance.Text.Length -1);
                    Balance.CaretIndex = Balance.Text.Length;
                    return int.Parse(Balance.Text);
                }
                else
                {
                    Balance.Text = String.Empty;
                    return null;
                }
            }
        }
    }
}
