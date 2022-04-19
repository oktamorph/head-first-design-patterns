namespace CommandPattern
{
    public class Stereo
    {
        string room;
        public Stereo() { }
        public Stereo(string room)
        {
            this.room = room;
        }
        public void On()
        {
            Console.WriteLine($"{room} stereo is on");
        }
        public void Off()
        {
            Console.WriteLine($"{room} stereo is off");
        }
        public void SetCd()
        {
            Console.WriteLine($"{room} stereo is set for CD input");
        }
        public void SetDvd()
        {
            Console.WriteLine($"{room} stereo is set for DVD input");
        }
        public void SetRadio()
        {
            Console.WriteLine($"{room} stereo is set for Radio");
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine($"{room} stereo volume set to {volume}");
        }
    }
}
