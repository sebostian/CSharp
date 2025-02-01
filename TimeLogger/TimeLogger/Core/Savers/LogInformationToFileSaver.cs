using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using TimeLogger.Core.Logs;

namespace TimeLogger.Core.Savers
{
	internal class LogInformationToFileSaver : IDataSaver<LogInformation>
	{
		private const string _folderName = "Logs";
		private const string _fileNamePrefix = "log";
		private const string _fileExtension = "txt";

		public async Task SaveAsync(string data)
		{
			await File.AppendAllLinesAsync(GetPath(), new List<string> { data });
		}

		public Task<string> ReadAsync()
		{
			throw new NotImplementedException();
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
