namespace AdapterAndFacadePatterns
{
    public class StreamingPlayer
    {
        private string? _movie;
        private Amplifier _amplifier;
        public void On()
        {
            Console.WriteLine("Streaming Player on");
        }
        public void Off()
        {
            Console.WriteLine("Streaming Player off");
        }
        public void Pause() { }
        public void Play(string movie)
        {
            _movie = movie;
            Console.WriteLine($"Streaming Player playing \"{_movie}\"");
        }
        public void SetSurroundAudio() { }
        public void SetTwoChannelAudio() { }
        public void Stop()
        {
            Console.WriteLine($"Streaming Player stopped \"{_movie}\"");
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
