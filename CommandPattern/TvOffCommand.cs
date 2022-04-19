namespace CommandPattern
{
    public class TvOffCommand : ICommand
    {
        readonly Tv tv;
        public TvOffCommand(Tv tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            tv.Off();
        }
        public void Undo()
        {
            tv.On();
            tv.SetInputChannel("News");
            tv.SetVolume(10);
        }
    }
}
