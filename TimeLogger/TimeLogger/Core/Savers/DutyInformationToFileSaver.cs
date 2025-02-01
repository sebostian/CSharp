using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using TimeLogger.Core.Duties;

namespace TimeLogger.Core.Savers
{
	public class DutyInformationToFileSaver : IDataSaver<DutyInformation>
	{
		private const string _folderName = "Logs";
		private const string _fileNamePrefix = "log";
		private const string _fileExtension = "di";

		public async Task SaveAsync(string data)
		{
			await File.WriteAllLinesAsync(GetPath(), new List<string> { data });
		}

		public async Task<string> ReadAsync()
		{
			return await File.ReadAllTextAsync(GetPath());
		}

		private static string GetPath()
		{
			CreateDirectoryIfRequired();

			DateTime dateTime = DateTime.UtcNow;

			return $"{_folderName}/{_fileNamePrefix}_{dateTime:yyyyMMdd}.{_fileExtension}";
		}

		private static void CreateDirectoryIfRequired()
		{
			if (!Directory.Exists(_folderName))
			{
				Directory.CreateDirectory(_folderName);
			}
		}
	}
}
