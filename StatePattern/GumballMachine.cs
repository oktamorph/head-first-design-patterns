namespace StatePattern
{
    public class GumballMachine
    {
        private readonly IState _soldOutState;
        private readonly IState _noQuarterState;
        private readonly IState _hasQuarterState;
        private readonly IState _soldState;

        private IState _state;
        private int _count = 0;

        public GumballMachine(int numberGumballs)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);

            this._count = numberGumballs; ;
            if (numberGumballs > 0)
                _state = _noQuarterState;
            else
                _state = _soldOutState;
        }
        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }
        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }
        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }
        public void SetState(IState state)
        {
            this._state = state;
        }
        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (_count > 0)
                _count = _count - 1;
        }
        public void GetNoQuarterState()
        {

        }
        public void GetCount()
        {

        }
    }

    public class GumballMachineTestDrive
    {
        public static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine + "\n\t");

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine();
            Console.WriteLine(gumballMachine + "\n\t");

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine();
            Console.WriteLine(gumballMachine + "\n\t");

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();

            Console.WriteLine();
            Console.WriteLine(gumballMachine + "\n\t");

            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine();
            Console.WriteLine(gumballMachine + "\n\t");
        }
    }
}
