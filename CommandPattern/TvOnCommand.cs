namespace CommandPattern
{
    public class TvOnCommand : ICommand
    {
        readonly Tv tv;
        public TvOnCommand(Tv tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            tv.On();
            tv.SetInputChannel("News");
            tv.SetVolume(10);
        }
        public void Undo()
        {
            tv.Off();
        }
    }
}
