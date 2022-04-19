namespace CommandPattern
{
    public class Hottub
    {
        public Hottub() { }
        public void On()
        {
            Console.WriteLine("Hottub is on");
        }
        public void Off()
        {
            Console.WriteLine("Hottub is off");
        }
        public void Circulate()
        {
            Console.WriteLine("Hottub is circulating");
        }
        public void JetsOn()
        {
            Console.WriteLine("Hottub activates jet mode");
        }
        public void JetsOff()
        {
            Console.WriteLine("Hottub deactivate jet mode");
        }
        public void SetTemperature(int temperature)
        {
            Console.WriteLine($"Hottub is heating to {temperature} degrees");
        }
    }
}
