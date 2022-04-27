namespace AdapterAndFacadePatterns
{
    public class Projector
    {
        private StreamingPlayer _player;
        public void On()
        {
            Console.WriteLine("Projector on");
        }
        public void Off()
        {
            Console.WriteLine("Projector off");
        }
        public void TvMode() { }
        public void WideScreenMode()
        {
            Console.WriteLine("Projector in widescreen mode (16x9 aspect ratio)");
        }
        public void SetInput(StreamingPlayer player) { }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
