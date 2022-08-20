namespace IteratorAndCompositePatterns
{
    public class PancakeHouseMenu : IMenu
    {
        private List<MenuItem> _menuItems;
        public PancakeHouseMenu()
        {
            _menuItems = new List<MenuItem>();
            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles with your choice of blueberries or strawberries", true, 3.59);
        }
        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(menuItem);
        }
        public Iterator<MenuItem> CreateIterator()
        {
            MenuItem[] items = new MenuItem[_menuItems.Count];
            
            for(var i = 0; i < items.Length; i++)
            {
                items[i] = _menuItems[i];
            }

            return new PancakeHouseMenuIterator(items);
        }
    }
}
