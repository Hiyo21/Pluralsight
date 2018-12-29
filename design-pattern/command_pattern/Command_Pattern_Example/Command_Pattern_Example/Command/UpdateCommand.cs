using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Example.Command
{
	class UpdateCommand : ICommand, ICommandFactory
	{
		public int NewQuantity { get; set; }

		public string CommandName => "Update";

		public string Description => "Updated to";

		public void execute()
		{
			Console.WriteLine("is Updated.");
			Console.WriteLine("From x To {0}", NewQuantity);
		}

		public ICommand MakeCommand(string[] args)
		{
			return new UpdateCommand {NewQuantity = int.Parse(args[1])};
		}
	}
}
