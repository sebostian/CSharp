using System;
using System.Windows;
using System.Windows.Threading;
using TimeLogger.Core;
using TimeLogger.Core.Logs;

namespace TimeLogger;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	private readonly Plan _plan;
	private readonly DispatcherTimer _timer;
	private readonly ILogInformationManager _logInformationManager;
	private const int _periodInMinutes = 1;

	public MainWindow(ILogInformationManager logInformationManager)
	{
		InitializeComponent();

		_logInformationManager = logInformationManager;

		_plan = new Plan
		{
			AskLogTime = TimeSpan.FromMinutes(_periodInMinutes)
		};

		_timer = new DispatcherTimer
		{
			Interval = _plan.AskLogTime
		};

		_timer.Tick += OnTick;
		_timer.Start();
	}

	private void OnTick(object sender, EventArgs e)
	{
		_timer.Stop();

		ToTop();

		_timer.Start();
	}

	private void ToTop()
	{
		if (!IsVisible)
		{
			Show();
		}

		if (WindowState == WindowState.Minimized)
		{
			WindowState = WindowState.Normal;
		}

		Activate();
		Topmost = true;  // important
		Topmost = false; // important
		Focus();         // important

	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		DateTime now = DateTime.UtcNow;
		//string nowAsString = now.ToString("HH:mm:ss");
		var logInfo = new LogInformation
		{
			SaveTime = now,
			Data = $"{tbLogData.Text}"
		};

		_logInformationManager.SaveAsync(logInfo);
	}
}
