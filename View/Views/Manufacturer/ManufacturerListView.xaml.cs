﻿using Models;
using SGUI_Home_Project.Store;
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
    /// Interaction logic for ManufacturerListWindow.xaml
    /// </summary>
    public partial class ManufacturerListView : UserControl
    {
        public ManufacturerListView()
        {
            InitializeComponent();
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstView.SelectedItem != null)
            {
                (DataContext as ManufacturerListViewModel).SelectedItemStore.SelectedItem = lstView.SelectedItem as Manufacturer;

            }
        }
    }
}
