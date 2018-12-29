using Command_Pattern_Example.Command;
using System;
using System.Linq;

namespace Command_Pattern_Example
{
    public class Program
    {
        static void Main(string[] args)
        {
	        //create available commands (in factory)
	        var availableCommands = getAvailableCommands();

	        if (!availableCommands.Any())
	        {
		        PrintHeader(availableCommands);
		        return;
	        }

			//decide which command should it run
	        var commandParser = new CommandParser(availableCommands);
	        var command = commandParser.Parse(args);

			//Clients can't send param to concrete command!
	        command.execute();
        }

		private static void PrintHeader(ICommandFactory[] availableCommands)
		{
			Console.WriteLine("this is header for example");
			Console.WriteLine("type in your command : update / create / delete : ");

			foreach (var command in availableCommands)
			{
				Console.WriteLine(command.Description);
			}
			
		}

		//create multiple commands using factory pattern
		private static ICommandFactory[] getAvailableCommands()
		{
			return new ICommandFactory[]
			{
				new UpdateCommand(),
				new CreateCommand(),
				new DeleteCommand(),
			};
		}
	}
}
