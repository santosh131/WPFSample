using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WpfApp1.Concrete;
using WpfApp1.Interface;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var sc = new ServiceCollection()
                .AddTransient<IEmployeeRepo, EmployeeRepo>()
                .BuildServiceProvider();

            Ioc.Default.ConfigureServices(sc);
            base.OnStartup(e);
        }

    }
}
