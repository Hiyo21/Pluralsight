using System;
using Command_Pattern_Example.Command;

namespace Command_Pattern_Example
{
	class NotFoundCommand : ICommand
	{
		public void execute()
		{
			Console.WriteLine("there's no such command");	
		}
	}
}