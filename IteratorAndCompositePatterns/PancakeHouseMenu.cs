namespace IteratorAndCompositePatterns
{
    public class PancakeHouseMenu : IMenu
    {
        private readonly Dictionary<string, MenuItem> _menuItems = new Dictionary<string, MenuItem>();
        public PancakeHouseMenu()
        {
            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles with your choice of blueberries or strawberries", true, 3.59);
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

            return new CafeMenuIterator(items);
        }
    }
}
