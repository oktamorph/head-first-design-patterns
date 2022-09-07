namespace IteratorAndCompositePatterns
{
    public class DessertMenu : IMenu
    {
        private readonly Dictionary<string, MenuItem> _menuItems = new Dictionary<string, MenuItem>();
        public DessertMenu()
        {
            AddItem("Apple Pie", "Apple pie with a flakey crust, topped with vanilla ice cream", true, 1.59);
            AddItem("Cheesecake", "Creamy New York cheesecake, with a chocolate graham crust", true, 1.99);
            AddItem("Sorbet", "A scoop of raspberry and a scoop of lime", true, 1.89);
        }
        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(name, menuItem);
        }
        public Iterator<MenuItem> CreateIterator()
        {
            var items = new MenuItem[_menuItems.Count];
            var counter = 0;

            foreach (var item in _menuItems)
            {
                items[counter] = item.Value;
                counter++;
            }

            return new DessertMenuIterator(items);
        }
    }
}
