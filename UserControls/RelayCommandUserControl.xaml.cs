﻿using System;
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
using WpfApp1.ViewModels;

namespace WpfApp1.UserControls
{
    /// <summary>
    /// Interaction logic for RelayCommandUserControl.xaml
    /// </summary>
    public partial class RelayCommandUserControl : UserControl
    {
        public EmployeeViewModel ViewModel {  get; set; }

        public RelayCommandUserControl()
        {
            InitializeComponent();
            ViewModel = new EmployeeViewModel();
            DataContext = ViewModel;
        }
         
    }
}
