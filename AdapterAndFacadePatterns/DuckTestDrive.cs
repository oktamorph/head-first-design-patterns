namespace AdapterAndFacadePatterns
{
    internal class DuckTestDrive
    {
        //private static void Main(string[] args)
        //{
        //    IDuck duck = new MallardDuck();
        //    ITurkey turkey = new WildTurkey();
        //    IDuck turkeyAdapter = new TurkeyAdapter(turkey);

        //    Console.WriteLine("The Turkey says...");
        //    turkey.Gobble();
        //    turkey.Fly();

        //    Console.WriteLine("\nThe Duck says...");
        //    TestDuck(duck);

        //    Console.WriteLine("\nThe TurkeyAdapter says...");
        //    TestDuck(turkeyAdapter);
        //}
        private static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
