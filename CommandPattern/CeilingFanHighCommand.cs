﻿namespace CommandPattern
{
    public class CeilingFanHighCommand : ICommand
    {
        readonly CeilingFan ceilingFan;
        int prevSpeed;
        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.High();
        }
        public void Undo()
        {
            if (prevSpeed == CeilingFan.HIGH)
            {
                ceilingFan.High();
            }
            else if (prevSpeed == CeilingFan.MEDIUM)
            {
                ceilingFan.Medium();
            }
            else if (prevSpeed == CeilingFan.LOW)
            {
                ceilingFan.Low();
            }
            else if (prevSpeed == CeilingFan.OFF)
            {
                ceilingFan.Off();
            }
        }
    }
}
