namespace CommandPattern
{
    public class GarageDoor
    {
        string room;
        public GarageDoor() { }
        public GarageDoor(string room)
        {
            this.room = room;
        }
        public void Up()
        {
            Console.WriteLine($"{room} garage door is open");
        }
        public void Down()
        {
            Console.WriteLine($"{room} garage door is closed");
        }
        public void Stop()
        {
            Console.WriteLine($"{room} garage door is stopped");
        }
        public void LightOn()
        {
            Console.WriteLine($"{room} garage door Light is on");
        }
        public void LightOff()
        {
            Console.WriteLine($"{room} garage door Light is off");
        }
    }
}
