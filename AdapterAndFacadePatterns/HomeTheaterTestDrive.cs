namespace AdapterAndFacadePatterns
{
    public class HomeTheaterTestDrive
    {
        public static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            Tuner tuner = new Tuner();
            StreamingPlayer player = new StreamingPlayer();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            PopcornPopper popper = new PopcornPopper();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, tuner, player, projector, screen, lights, popper);
            homeTheater.WatchMovie("Raiders of the Lost Ark");
            homeTheater.EndMovie();
        }
    }
}
