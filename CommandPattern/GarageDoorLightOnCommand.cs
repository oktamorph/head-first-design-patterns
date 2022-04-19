namespace CommandPattern
{
    public class GarageDoorLightOnCommand : ICommand
    {
        readonly GarageDoor garageDoor;
        public GarageDoorLightOnCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.LightOn();
        }
        public void Undo()
        {
            garageDoor.LightOff();
        }
    }
}
