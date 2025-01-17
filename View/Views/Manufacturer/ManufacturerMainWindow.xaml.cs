﻿using SGUI_Home_Project.Store;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SGUI_Home_Project
{
    /// <summary>
    /// Interaction logic for ManufacturerMainWindow.xaml
    /// </summary>
    public partial class ManufacturerMainWindow : Window
    {
        public ManufacturerMainWindow()
        {
            InitializeComponent();
            DataContext = new ManufacturerViewModel(this);
        }
    }
}
