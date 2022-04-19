namespace CommandPattern
{
    public class GarageDoorStopCommand : ICommand
    {
        readonly GarageDoor garageDoor;
        public GarageDoorStopCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.Stop();
        }
        public void Undo()
        {
            garageDoor.Stop();
        }
    }
}
