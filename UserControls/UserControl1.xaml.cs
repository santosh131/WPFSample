using CommunityToolkit.Mvvm.DependencyInjection;
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
using WpfApp1.Interface;

namespace WpfApp1.UserControls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private readonly IEmployeeRepo _employeeRepo;
        public UserControl1()
        {
            InitializeComponent();
            _employeeRepo = Ioc.Default.GetService<IEmployeeRepo>();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            var val = _employeeRepo.GetEmployee();
        }
    }
}
