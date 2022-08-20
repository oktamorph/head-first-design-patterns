namespace IteratorAndCompositePatterns
{
    public class MenuTestDrive
    {
        public static void Main(string[] args)
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();
            CafeMenu cafeMenu = new CafeMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu, cafeMenu);
            waitress.PrintMenu();

            List<MenuItem> menu = new List<MenuItem>();
            foreach (MenuItem item in menu)
            {
                Console.WriteLine(item.GetName() + ", ");
                Console.WriteLine(item.GetPrice() + " -- ");
                Console.WriteLine(item.GetDescription());
            }
        }
    }
}
