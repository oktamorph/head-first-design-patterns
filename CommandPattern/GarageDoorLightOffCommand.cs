namespace CommandPattern
{
    public class GarageDoorLightOffCommand : ICommand
    {
        readonly GarageDoor garageDoor;
        public GarageDoorLightOffCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.LightOff();
        }
        public void Undo()
        {
            garageDoor.LightOn();
        }
    }
}
