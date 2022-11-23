namespace StatePattern
{
    public class HasQuarterState : IState
    {
        private Random _randomWinnner = new Random(CurrentTimeMilliseconds());
        private readonly GumballMachine _gumballMachine;
        public HasQuarterState(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }
        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
        }
        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = _randomWinnner.Next(10);
            if ((winner == 0) && (_gumballMachine.GetCount() > 1))
                _gumballMachine.SetState(_gumballMachine.GetWinnerState());
            else
                _gumballMachine.SetState(_gumballMachine.GetSoldState());
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
        private static int CurrentTimeMilliseconds()
        {
            DateTime Oct18th2022 = new DateTime(2022, 10, 18, 0, 0, 0, DateTimeKind.Utc);
            return (int)(DateTime.UtcNow - Oct18th2022).TotalMilliseconds;
        }
        public void Refill() { }
    }
}
