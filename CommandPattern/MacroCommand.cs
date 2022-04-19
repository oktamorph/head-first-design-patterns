namespace CommandPattern
{
    public class MacroCommand : ICommand
    {
        readonly ICommand[] commands;
        public MacroCommand(ICommand[] commands)
        {
            this.commands = commands;
        }
        public void Execute()
        {
            for(int i = 0; i < commands.Length; i++)
            {
                commands[i].Execute();
            }
        }
        public void Undo()
        {
            for(int i = commands.Length - 1; i >= 0; i--)
            {
                commands[i].Undo();
            }
        }
    }
}
