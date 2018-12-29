using System;
using System.Collections.Generic;
using System.Linq;
using Command_Pattern_Example.Command;

namespace Command_Pattern_Example
{
	public class CommandParser
	{
		private readonly IEnumerable<ICommandFactory> availableCommands;

		public CommandParser(IEnumerable<ICommandFactory> availableCommands)
		{
			this.availableCommands = availableCommands;
		}

		public ICommand Parse(string[] args)
		{	
			var command = FindRequestedCommand(args[0]);
			if (command == null) return new NotFoundCommand();

			return command.MakeCommand(args);
		}

		ICommandFactory FindRequestedCommand(string argument)
		{
			return availableCommands.FirstOrDefault(x => x.CommandName == argument);
		}
	}
}