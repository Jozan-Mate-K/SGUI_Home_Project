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

namespace SGUI_Home_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ManufacturerButton(object sender, RoutedEventArgs e)
        {
            ManufacturerMainWindow manufacturerMainWindow = new ManufacturerMainWindow();
            manufacturerMainWindow.Show();
        }

        private void BandButton(object sender, RoutedEventArgs e)
        {
            BandMainWindow bandMainWindow = new BandMainWindow();
            bandMainWindow.Show();
        }

        private void InstrumentButton(object sender, RoutedEventArgs e)
        {
            InstrumentWindow instrumentWindow = new InstrumentWindow();
            instrumentWindow.Show();
        }
    }
}
