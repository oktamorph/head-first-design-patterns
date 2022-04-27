namespace AdapterAndFacadePatterns
{
    public class Screen
    {
        public void Up()
        {
            Console.WriteLine("Theater Screen going up");
        }
        public void Down()
        {
            Console.WriteLine("Theater Screen going down");
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
