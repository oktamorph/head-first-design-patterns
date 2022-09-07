namespace IteratorAndCompositePatterns
{
    public class Waitress
    {
        private readonly MenuComponent _allMenus;
        public Waitress(MenuComponent allMenus)
        {
            this._allMenus = allMenus;
        }
        public void PrintMenu()
        {
            ((Menu)_allMenus).Print();
        }
    }
}
