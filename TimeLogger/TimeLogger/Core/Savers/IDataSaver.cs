using System.Threading.Tasks;

namespace TimeLogger.Core.Savers
{
	internal interface IDataSaver<T>
	{
		Task SaveAsync(string data);
		Task<string> ReadAsync();
	}
}
