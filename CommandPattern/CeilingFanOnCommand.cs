namespace CommandPattern
{
    public class CeilingFanOnCommand : ICommand
    {
        readonly CeilingFan ceilingFan;
        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            ceilingFan.On();
        }
        public void Undo()
        {
            ceilingFan.Off();
        }
    }
}
