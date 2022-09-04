namespace IteratorAndCompositePatterns
{
    public class Waitress
    {
        //private readonly IMenu _pancakeHouseMenu;
        //private readonly IMenu _dinerMenu;
        //private readonly IMenu _cafeMenu;

        //public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu, IMenu cafeMenu)
        //{
        //    this._pancakeHouseMenu = pancakeHouseMenu;
        //    this._dinerMenu = dinerMenu;
        //    this._cafeMenu = cafeMenu;
        //}
        //public void PrintMenu()
        //{
        //    Iterator<MenuItem> pancakeIterator = _pancakeHouseMenu.CreateIterator();
        //    Iterator<MenuItem> dinerIterator = _dinerMenu.CreateIterator();
        //    Iterator<MenuItem> cafeIterator = _cafeMenu.CreateIterator();

        //    Console.WriteLine("MENU\n----\nBREAKFAST");
        //    PrintMenu(pancakeIterator);

        //    Console.WriteLine("\nLUNCH");
        //    PrintMenu(dinerIterator);

        //    Console.WriteLine("\nDINNER");
        //    PrintMenu(cafeIterator);
        //}
        //private readonly List<IMenu> _menus;
        //public Waitress(List<IMenu> menus)
        //{
        //    this._menus = menus;
        //}
        //public void PrintMenu()
        //{
        //    var menuIterator = _menus.GetEnumerator();
        //    while (menuIterator.MoveNext())
        //    {
        //        IMenu menu = menuIterator.Current;
        //        PrintMenu(menu.CreateIterator());
        //    }
        //}
        //private void PrintMenu(Iterator<MenuItem> iterator)
        //{
        //    while (iterator.HasNext())
        //    {
        //        MenuItem menuItem = iterator.Next();
        //        Console.Write(menuItem.GetName() + ", ");
        //        Console.Write(menuItem.GetPrice() + " -- ");
        //        Console.WriteLine(menuItem.GetDescription());
        //    }
        //}

        private MenuComponent _allMenus;
        public Waitress(MenuComponent allMenus)
        {
            this._allMenus = allMenus;
        }
        public void PrintMenu()
        {
            _allMenus.Print();
        }
    }
}
