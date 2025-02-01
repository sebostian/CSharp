using System.Threading.Tasks;

namespace TimeLogger.Core.Duties;

internal interface IDutyInformationManager
{
	Task Save(DutyInformation information);
	Task<DutyInformation> Read();
}
