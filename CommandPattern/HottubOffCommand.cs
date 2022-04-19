namespace CommandPattern
{
    public class HottubOffCommand : ICommand
    {
        readonly Hottub hottub;
        public HottubOffCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }
        public void Execute()
        {
            hottub.Off();
        }
        public void Undo()
        {
            hottub.On();
            hottub.SetTemperature(100);
        }
    }
}
