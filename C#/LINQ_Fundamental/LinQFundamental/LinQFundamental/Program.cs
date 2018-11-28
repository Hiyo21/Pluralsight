using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayWithoutLINQ
{
	class Program
	{
		static void Main(string[] args)
		{
			// how to get filepath
			// current directory : Environment objectから
			//TODO: how to convert filepath from relative to absolute and vice versa
			var basepath = $@"{Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\Resources";
			Console.WriteLine(basepath);
			var directoryInfo = new DirectoryInfo(basepath);
			var fileInfos = directoryInfo.EnumerateFiles();
			ShowLargeFilesWithoutLinq(fileInfos);
			Console.Read();
		}
		
		private static void ShowLargeFilesWithoutLinq(IEnumerable<FileInfo> fileInfos)
		{
			var fileInfoArray = fileInfos.ToArray();
			foreach (var i in fileInfoArray)
			{
				Console.WriteLine(i.Name + "//"  + i.Length);
			}
			Console.WriteLine();

			Array.Sort(fileInfoArray, CompareFileSize);

			foreach (var i in fileInfoArray)
			{
				Console.WriteLine(i.Name + "//" + i.Length);
			}
		}

		private static int CompareFileSize(FileInfo f1, FileInfo f2)
		{
			if (f1.Length > f2.Length)
			{
				return -1;
			}else if (f1.Length == f2.Length)
			{
				return 0;
			}
			else
			{
				return 1;
			}

		}
	}
}
