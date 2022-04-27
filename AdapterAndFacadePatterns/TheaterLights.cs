namespace AdapterAndFacadePatterns
{
    public class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Theater Ceiling Lights on");
        }
        public void Off() { }
        public void Dim(int light)
        {
            Console.WriteLine($"Theater Ceiling Lights dimming to {light}%");
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
