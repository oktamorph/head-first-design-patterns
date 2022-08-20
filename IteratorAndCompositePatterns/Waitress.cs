namespace IteratorAndCompositePatterns
{
    public class Waitress
    {
        private IMenu _pancakeHouseMenu;
        private IMenu _dinerMenu;
        private IMenu _cafeMenu;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu, IMenu cafeMenu)
        {
            this._pancakeHouseMenu = pancakeHouseMenu;
            this._dinerMenu = dinerMenu;
            this._cafeMenu = cafeMenu;
        }
        public void PrintMenu()
        {
            Iterator<MenuItem> pancakeIterator = _pancakeHouseMenu.CreateIterator();
            Iterator<MenuItem> dinerIterator = _dinerMenu.CreateIterator();
            Iterator<MenuItem> cafeIterator = _cafeMenu.CreateIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
            Console.WriteLine("\nDINNER");
            PrintMenu(cafeIterator);
        }
        private void PrintMenu(Iterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                Console.Write(menuItem.GetName() + ", ");
                Console.Write(menuItem.GetPrice() + " -- ");
                Console.WriteLine(menuItem.GetDescription());
            }
        }
    }
}
