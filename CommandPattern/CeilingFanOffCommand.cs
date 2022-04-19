namespace CommandPattern
{
    public class CeilingFanOffCommand : ICommand
    {
        readonly CeilingFan ceilingFan;
        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            ceilingFan.Off();
        }
        public void Undo()
        {
            ceilingFan.On();
        }
    }
}
