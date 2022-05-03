namespace TemplateMethodPattern
{
    public class BeverageTestDrive
    {
        public static void Main(string[] args)
        {
            TeaWithHook teaHook = new TeaWithHook();
            CoffeeWithHook coffeeWithHook = new CoffeeWithHook();

            Console.WriteLine("\nMaking tea...");
            teaHook.PrepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffeeWithHook.PrepareRecipe();
        }
    }
}
