namespace Chapter01
{
    internal class MuteQuack : IQuackBehavior
    {
        public void Quacks()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
