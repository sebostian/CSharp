using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using TimeLogger.Core.Duties;
using TimeLogger.Core.Logs;
using TimeLogger.Core.Savers;

namespace TimeLogger
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private ServiceProvider _serviceProvider;

		public App()
		{
			var services = new ServiceCollection();
			ConfigureServices(services);
			_serviceProvider = services.BuildServiceProvider();
		}

		private static void ConfigureServices(ServiceCollection services)
		{
			services.AddSingleton<MainWindow>();
			services.AddSingleton<IDataSaver<LogInformation>, LogInformationToFileSaver>();
			services.AddSingleton<IDataSaver<DutyInformation>, DutyInformationToFileSaver>();
			services.AddSingleton<ILogInformationManager, LogInformationManager>();
			services.AddSingleton<IDutyInformationManager, DutyInformationManager>();
		}

		private void OnStartup(object sender, StartupEventArgs e)
		{
			MainWindow mainWindow = _serviceProvider.GetService<MainWindow>();
			mainWindow.Show();
		}
	}
}
