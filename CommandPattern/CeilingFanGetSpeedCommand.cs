namespace CommandPattern
{
    public class CeilingFanGetSpeedCommand : ICommand
    {
        readonly CeilingFan ceilingFan;
        public CeilingFanGetSpeedCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            ceilingFan.GetSpeed();
        }
        public void Undo()
        {
            ceilingFan.GetSpeed();
        }
    }
}
