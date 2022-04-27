﻿namespace AdapterAndFacadePatterns
{
    public class HomeTheaterFacade
    {
        private readonly Amplifier _amp;
        private readonly Tuner _tuner;
        private readonly StreamingPlayer _player;
        private readonly Projector _projector;
        private readonly TheaterLights _lights;
        private readonly Screen _screen;
        private readonly PopcornPopper _popper;
        public HomeTheaterFacade(Amplifier amp, Tuner tuner, StreamingPlayer player, Projector projector,
            Screen screen, TheaterLights lights, PopcornPopper popper)
        {
            this._amp = amp;
            this._tuner = tuner;
            this._player = player;
            this._projector = projector;
            this._screen = screen;
            this._lights = lights;
            this._popper = popper;
        }
        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");

            _popper.On();
            _popper.Pop();
            _lights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amp.On();
            _amp.SetStreamingPlayer(_player);
            _amp.SetSurroundSound();
            _amp.SetVolume(5);
            _player.On();
            _player.Play(movie);
        }
        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");

            _popper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _player.Stop();
            _player.Off();
        }
        public void ListenToRadio() { }
        public void EndRadio() { }
    }
}
