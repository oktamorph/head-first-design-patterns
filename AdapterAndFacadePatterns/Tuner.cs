namespace AdapterAndFacadePatterns
{
    public class Tuner
    {
        private Amplifier _amplifier;
        public void On() { }
        public void Off() { }
        public void SetAm() { }
        public void SetFm() { }
        public void SetFrequency() { }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
