namespace CommandPattern
{
    public class StereoOnWithDvdCommand : ICommand
    {
        readonly Stereo stereo;
        public StereoOnWithDvdCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.On();
            stereo.SetDvd();
            stereo.SetVolume(12);
        }
        public void Undo()
        {
            stereo.Off();
        }
    }
}
