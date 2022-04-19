namespace CommandPattern
{
    public class CeilingFan
    {
        public static readonly int ON = 4;
        public static readonly int HIGH = 3;
        public static readonly int MEDIUM = 2;
        public static readonly int LOW = 1;
        public static readonly int OFF = 0;
        readonly string room;
        int speed;
        public CeilingFan() { }
        public CeilingFan(string room)
        {
            this.room = room;
            speed = OFF;
        }
        public void High()
        {
            speed = HIGH;
            Console.WriteLine($"{room} ceiling fan speed is on {speed}");
        }
        public void Medium()
        {
            speed = MEDIUM;
            Console.WriteLine($"{room} ceiling fan speed is on {speed}");
        }
        public void Low()
        {
            speed = LOW;
            Console.WriteLine($"{room} ceiling fan speed is on {speed}");
        }
        public void On()
        {
            speed = ON;
            Console.WriteLine($"{room} ceiling fan is on {speed}");
        }
        public void Off()
        {
            speed = OFF;
            Console.WriteLine($"{room} ceiling fan is off");
        }
        public int GetSpeed()
        {
            Console.WriteLine($"{room} ceiling fan speed is {speed}");
            return speed;
        }
    }
}
