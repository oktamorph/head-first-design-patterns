namespace IteratorAndCompositePatterns
{
    public class Menu : MenuComponent
    {
        private List<MenuComponent> _menuComponents = new List<MenuComponent>();
        private string _name;
        private string _description;
        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }
        public void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }
        public MenuComponent GetChild(int i)
        {
            return _menuComponents[i];
        }
        public string GetName()
        {
            return _name;
        }
        public string GetDescription()
        {
            return _description;
        }
        public void Print()
        {
            Console.Write("\n" + GetName());
            Console.WriteLine(", " + GetDescription());
            Console.WriteLine("---------------------");

            foreach(var menuComponent in _menuComponents)
            {
                ((Menu)menuComponent).Print();
            }
        }
    }
}
