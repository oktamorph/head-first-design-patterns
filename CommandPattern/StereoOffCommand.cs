namespace CommandPattern
{
    public class StereoOffCommand : ICommand
    {
        readonly Stereo stereo;
        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.Off();
        }
        public void Undo()
        {
            stereo.On();
        }
    }
}
