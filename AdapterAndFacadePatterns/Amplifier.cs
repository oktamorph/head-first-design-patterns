namespace AdapterAndFacadePatterns
{
    public class Amplifier
    {
        private Tuner _tuner;
        private StreamingPlayer _player;
        public void On()
        {
            Console.WriteLine("Amplifier on");
        }
        public void Off()
        {
            Console.WriteLine("Amplifier off");
        }
        public void SetStreamingPlayer(StreamingPlayer player)
        {
            Console.WriteLine("Amplifier setting Streaming player to Streaming Player");
        }
        public void SetStereoSound() { }
        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier surround sound on (5 speakers, 1 subwoofer)");
        }
        public void SetTuner() { }
        public void SetVolume(int volume)
        {
            Console.WriteLine($"Amplifier setting volume to {volume}");
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
