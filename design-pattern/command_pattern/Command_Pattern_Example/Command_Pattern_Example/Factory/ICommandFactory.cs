using Command_Pattern_Example.Command;

namespace Command_Pattern_Example
{
	public interface ICommandFactory
	{
		string CommandName { get; }
		string Description { get; }
		ICommand MakeCommand(string[] args);
	}
}