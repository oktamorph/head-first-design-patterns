namespace CommandPattern
{
    public class GarageDoorUpCommand : ICommand
    {
        readonly GarageDoor garageDoor;
        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.Up();
        }
        public void Undo()
        {
            garageDoor.Down();
        }
    }
}
