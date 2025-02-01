namespace TimeLogger.Core.Logs
{
	public interface ILogInformationManager
	{
		void SaveAsync(LogInformation information);
		LogInformation Read();
	}
}
