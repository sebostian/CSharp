using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using TimeLogger.Core.Savers;

namespace TimeLogger.Core.Duties;

internal class DutyInformationManager : IDutyInformationManager
{
	private readonly IDataSaver<DutyInformation> _dataSaver;

	public DutyInformationManager(IDataSaver<DutyInformation> dataSaver)
	{
		_dataSaver = dataSaver;
	}

	public async Task<DutyInformation> Read()
	{
		return JsonConvert.DeserializeObject<DutyInformation>(await _dataSaver.ReadAsync());
	}

	public Task Save(DutyInformation information)
	{
		throw new NotImplementedException();
	}
}
