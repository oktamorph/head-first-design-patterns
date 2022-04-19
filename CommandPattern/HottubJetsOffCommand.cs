namespace CommandPattern
{
    public class HottubJetsOffCommand : ICommand
    {
        readonly Hottub hottub;
        public HottubJetsOffCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }
        public void Execute()
        {
            hottub.JetsOff();
        }
        public void Undo()
        {
            hottub.JetsOn();
            hottub.Circulate();
        }
    }
}
