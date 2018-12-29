using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example.Command
{
	class CreateCommand : ICommand, ICommandFactory
	{
		private int newQuantity; 

		public string CommandName => "Create";

		public string Description => string.Format("Created New Record of value {0}", newQuantity);

		public void execute()
		{
			Console.WriteLine("is create.");
			Console.WriteLine("new record is created with value " + Description);
		}

		public ICommand MakeCommand(string[] args) => new CreateCommand() { newQuantity = int.Parse(args[1]) };
	}
}
