namespace IteratorAndCompositePatterns
{
    public class DinerMenu : IMenu
    {
        private readonly Dictionary<string, MenuItem> _menuItems = new Dictionary<string, MenuItem>();
        public DinerMenu()
        {
            AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("Hotdog", "A hot dog, with sauerkraut, relish, onions, topped with cheese", false, 3.05);
            AddItem("Steamed Veggies and Brown Rice", "Steamed vegetables over brown rice", true, 3.99);
            AddItem("Pasta", "Spaghetti with marina sauce, and a slice of soudough bread", true, 3.89);
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
