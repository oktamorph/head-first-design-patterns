namespace CommandPattern
{
    public class Tv
    {
        string room;
        public Tv() { }
        public Tv(string room)
        {
            this.room = room;
        }
        public void On()
        {
            Console.WriteLine($"{room} TV is on");
        }
        public void Off()
        {
            Console.WriteLine($"{room} TV is off");
        }
        public void SetInputChannel(string channel)
        {
            Console.WriteLine($"{room} TV channel is set to {channel}");
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine($"{room} TV volume is set to {volume}");
        }
    }
}
