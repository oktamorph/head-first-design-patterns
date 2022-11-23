using StatePattern;

namespace ProxyPattern
{
    public class GumballMonitor
    {
        private readonly GumballMachine _machine;
        public GumballMonitor(GumballMachine machine)
        {
            this._machine= machine;
        }
        public void Report()
        {
            Console.WriteLine("Gumball Machine: " + _machine.GetLocation());
            Console.WriteLine("Current Inventory: " + _machine.GetCount() + " gumballs");
            Console.WriteLine("Current state: " + _machine.GetState());
        }
    }
}
