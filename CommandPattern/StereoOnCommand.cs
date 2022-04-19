namespace CommandPattern
{
    public class StereoOnCommand : ICommand
    {
        readonly Stereo stereo;
        public StereoOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.On();
        }
        public void Undo()
        {
            stereo.Off();
        }
    }
}
