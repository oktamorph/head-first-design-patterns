namespace StatePattern
{
    public class HasQuarterState : IState
    {
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
            _gumballMachine.SetState(_gumballMachine.GetSoldState());
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
