namespace CommandPattern
{
    public class CeilingFanLowCommand : ICommand
    {
        readonly CeilingFan ceilingFan;
        int prevSpeed;
        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.Low();
        }
        public void Undo()
        {
            if (prevSpeed == CeilingFan.LOW)
            {
                ceilingFan.Low();
            }
            else if (prevSpeed == CeilingFan.MEDIUM)
            {
                ceilingFan.Medium();
            }
            else if (prevSpeed == CeilingFan.HIGH)
            {
                ceilingFan.Low();
            }
            else if (prevSpeed == CeilingFan.HIGH)
            {
                ceilingFan.Off();
            }
        }
    }
}
