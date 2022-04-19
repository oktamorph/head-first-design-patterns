namespace CommandPattern
{
    public class HottubJetsOnCommand : ICommand
    {
        readonly Hottub hottub;
        public HottubJetsOnCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }
        public void Execute()
        {
            hottub.JetsOn();
        }
        public void Undo()
        {
            hottub.JetsOff();
        }
    }
}
