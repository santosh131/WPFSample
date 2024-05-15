using System.Windows.Input;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using WpfApp1.Interface;

namespace WpfApp1.ViewModels
{
    public class EmployeeViewModel
    {
        private readonly IEmployeeRepo _employeeRepo;
        public EmployeeViewModel()
        {
            _employeeRepo = Ioc.Default.GetService<IEmployeeRepo>();
            EmployeeSearchCommand = new RelayCommand(SearchClick);
        }

        public int Id { get; set; }

        public ICommand EmployeeSearchCommand { get; }

        private void SearchClick()
        {
            var val = _employeeRepo.GetEmployee();
        }

    }
}
