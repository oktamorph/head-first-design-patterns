namespace StatePattern
{
    public class GumballMachine
    {
        private readonly static int SOLD_OUT = 0;
        private readonly static int NO_QUARTER = 1;
        private readonly static int HAS_QUARTER = 2;
        private readonly static int SOLD = 3;

        private int _state = SOLD_OUT;
        private int _count = 0;

        public GumballMachine(int count)
        {
            this._count = count;
            if (count > 0)
                _state = NO_QUARTER;
        }
        public void InsertQuarter()
        {
            if (_state == HAS_QUARTER)
                Console.WriteLine("You can't insert another quarter");
            else if (_state == NO_QUARTER)
            {
                _state = HAS_QUARTER;
                Console.WriteLine("You inserted a quarter");
            }
            else if (_state == SOLD_OUT)
                Console.WriteLine("You can't insert a quarter, the machine is sold out");
            else if (_state == SOLD)
                Console.WriteLine("Please wait, we're already giving you a gumball");
        }
        public void EjectQuarter()
        {
            if (_state == HAS_QUARTER)
            {
                Console.WriteLine("Quarter returned");
                _state = NO_QUARTER;
            }
            else if (_state == NO_QUARTER)
                Console.WriteLine("You haven't inserted a quarter");
            else if (_state == SOLD)
                Console.WriteLine("Sorry, you already turned the crank");
            else if (_state == SOLD_OUT)
                Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }
        public void TurnCrank()
        {
            if (_state == SOLD)
                Console.WriteLine("Turning twice doesn't get you another gumball!");
            else if (_state == NO_QUARTER)
                Console.WriteLine("You turned but there's no quarter");
            else if (_state == SOLD_OUT)
                Console.WriteLine("You turned but there are no gumballs");
            else if (_state == HAS_QUARTER)
            {
                Console.WriteLine("You turned...");
                _state = SOLD;
                Dispense();
            }
        }
        public void Dispense()
        {
            if (_state == SOLD)
            {
                Console.WriteLine("A gumball comes rolling out the slot");
                _count = _count - 1;
                if (_count == 0)
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    _state = SOLD;
                }
                else
                    _state = NO_QUARTER;
            }
            else if (_state == NO_QUARTER)
                Console.WriteLine("You need yo pay first");
            else if (_state == SOLD_OUT)
                Console.WriteLine("No gumball dispensed");
            else if (_state == HAS_QUARTER)
                Console.WriteLine("You need to turn the crank");
        }

        //  other methods here like ToString() and Refill()
    }
}
