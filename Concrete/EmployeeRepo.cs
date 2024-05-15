using WpfApp1.Interface;

namespace WpfApp1.Concrete
{
    public class EmployeeRepo : IEmployeeRepo
    {
        public string GetEmployee()
        {
            return "Hello";
        }
    }
}
