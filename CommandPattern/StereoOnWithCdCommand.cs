namespace CommandPattern
{
    public class StereoOnWithCdCommand : ICommand
    {
        readonly Stereo stereo;
        public StereoOnWithCdCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.On();
            stereo.SetCd();
            stereo.SetVolume(11);
        }
        public void Undo()
        {
            stereo.Off();
        }
    }
}
