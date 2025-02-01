using Newtonsoft.Json;
using System;
using TimeLogger.Core.Duties;
using TimeLogger.Core.Savers;

namespace TimeLogger.Core.Logs;

internal class LogInformationManager : ILogInformationManager
{
	private readonly IDataSaver<LogInformation> _dataSaver;
	private readonly IDataSaver<DutyInformation> _dutySaver;

	public LogInformationManager(IDataSaver<LogInformation> dataSaver, IDataSaver<DutyInformation> dutySaver)
	{
		_dataSaver = dataSaver;
		_dutySaver = dutySaver;
	}

	public LogInformation Read()
	{
		throw new NotImplementedException();
	}

	public async void SaveAsync(LogInformation information)
	{
		await _dataSaver.SaveAsync(JsonConvert.SerializeObject(information));
		//await _dutySaver.SaveAsync(JsonConvert.SerializeObject(new DutyInformation() { LastSave = DateTime.UtcNow }));
	}
}
