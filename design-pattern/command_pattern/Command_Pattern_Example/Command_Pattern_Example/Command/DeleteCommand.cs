using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example.Command
{
	class DeleteCommand : ICommand, ICommandFactory
	{
		public string CommandName => "Delete";

		public string Description => "Record is Deleted";

		public void execute()
		{
			Console.WriteLine(Description);
		}

		public ICommand MakeCommand(string[] args)
		{
			return new DeleteCommand().MakeCommand(args);
		}
	}
}
