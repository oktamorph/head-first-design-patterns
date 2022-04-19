namespace CommandPattern
{
    public class Light
    {
        string room;
        public Light() { }
        public Light(string room)
        {
            this.room = room;
        }
        public void On()
        {
            Console.WriteLine($"{room} light is on");
        }
        public void Off()
        {
            Console.WriteLine($"{room} light is off");
        }
        public void Dim()
        {
            Console.WriteLine($"{room} is dimmed");
        }
    }
}
