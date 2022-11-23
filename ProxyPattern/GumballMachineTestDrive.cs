using ProxyPattern;
using StatePattern;

public class GumballMachineTestDrive
{
    public static void Main(string[] args)
    {
        int count = 0;

        if (args.Length < 2)
        {
            Console.WriteLine("Gumball Machine <name> <inventory>");
            Environment.Exit(1);
        }

        Int32.TryParse(args[1], out count);
        GumballMachine gumballMachine = new GumballMachine(args[0], count);
        GumballMonitor monitor = new GumballMonitor(gumballMachine);

        //Console.WriteLine(gumballMachine);

        //gumballMachine.InsertQuarter();
        //gumballMachine.TurnCrank();

        //Console.WriteLine("\n" + gumballMachine);

        //gumballMachine.InsertQuarter();
        //gumballMachine.TurnCrank();
        //gumballMachine.InsertQuarter();
        //gumballMachine.TurnCrank();

        //Console.WriteLine("\n" + gumballMachine);
        //gumballMachine.Refill(3);

        monitor.Report();
    }
}