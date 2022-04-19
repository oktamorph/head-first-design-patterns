namespace CommandPattern
{
    public class HottubOnCommand : ICommand
    {
        readonly Hottub hottub;
        public HottubOnCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }
        public void Execute()
        {
            hottub.On();
            hottub.SetTemperature(100);
            hottub.Circulate();
        }
        public void Undo()
        {
            hottub.Off();
        }
    }
}
