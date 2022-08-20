namespace IteratorAndCompositePatterns
{
    public class CafeMenu : IMenu
    {
        private readonly Dictionary<string, MenuItem> _menuItems = new Dictionary<string, MenuItem>();
        public CafeMenu()
        {
            AddItem("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69);
            AddItem("Burrito", "A larte buritto, with whole pinto beans, salsa, guacamole", true, 4.29);
            AddItem("Veggie Burger and Air Fries", "Veggie Burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99);
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

            foreach(var item in _menuItems)
            {
                items[counter] = item.Value;
                counter++;
            }

            return new CafeMenuIterator(items);
        }
    }
}