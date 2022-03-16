namespace Chapter01
{
    internal class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
