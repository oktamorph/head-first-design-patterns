﻿using System.Text;

namespace StatePattern
{
    public class GumballMachine
    {
        private readonly IState _soldOutState;
        private readonly IState _noQuarterState;
        private readonly IState _hasQuarterState;
        private readonly IState _soldState;
        private readonly IState _winnerState;

        private IState _state;
        private int _count = 0;

        public GumballMachine(int numberGumballs)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _winnerState = new WinnerState(this);

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
        public IState GetNoQuarterState()
        {
            return _noQuarterState;
        }
        public IState GetSoldOutState()
        {
            return _soldOutState;
        }
        public IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }
        public IState GetSoldState()
        {
            return _soldState;
        }
        public IState GetWinnerState()
        {
            return _winnerState;
        }
        public int GetCount()
        {
            return _count;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Mighty Gumball, Inc.");
            stringBuilder.Append("\nC#-enabled Standing Gumball Model #2004");
            stringBuilder.Append($"\nInventory: {_count} gumballs");
            stringBuilder.Append("\nMachine is waiting for quarter\n");

            return stringBuilder.ToString();
        }
        public void Refill(int count)
        {
            _count = count;
            Console.WriteLine("The gumball machine we just refilled; its new count is: " + this._count);
            _state.Refill();
        }
    }

    public class GumballMachineTestDrive
    {
        public static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine("\n" + gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine("\n" + gumballMachine);
            gumballMachine.Refill(3);
        }
    }
}
