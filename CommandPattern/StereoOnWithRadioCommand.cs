namespace CommandPattern
{
    public class StereoOnWithRadioCommand : ICommand
    {
        readonly Stereo stereo;
        public StereoOnWithRadioCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.On();
            stereo.SetRadio();
            stereo.SetVolume(13);
        }
        public void Undo()
        {
            stereo.Off();
        }
    }
}
