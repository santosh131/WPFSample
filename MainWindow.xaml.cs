using CommunityToolkit.Mvvm.DependencyInjection;
using System.Windows;
using WpfApp1.Interface;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IEmployeeRepo _employeeRepo;
        public MainWindow()
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
