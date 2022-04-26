namespace AdapterAndFacadePatterns
{
    internal class MallardDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
