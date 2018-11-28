using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayWithLINQ
{
	class Program
	{
		static void Main(string[] args)
		{
			var basepath = $@"{Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\Resources";
			Console.WriteLine(basepath);
			var fileInfos = new DirectoryInfo(basepath).EnumerateFiles();
			ShowLargeFilesWithLinq(fileInfos);
			Console.Read();
		}

		private static void ShowLargeFilesWithLinq(IEnumerable<FileInfo> fileInfos)
		{
			var top5 = fileInfos.OrderByDescending(_ => _.Length).Take(5);

			foreach (var i in top5)
			{
				Console.WriteLine($"{i.Name} // {i.Length}");
			}
		}
	}
}
