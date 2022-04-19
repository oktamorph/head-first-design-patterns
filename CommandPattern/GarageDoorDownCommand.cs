namespace CommandPattern
{
    public class GarageDoorDownCommand : ICommand
    {
        readonly GarageDoor garageDoor;
        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.Down();
        }
        public void Undo()
        {
            garageDoor.Up();
        }
    }
}
