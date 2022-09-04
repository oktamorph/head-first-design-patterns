namespace IteratorAndCompositePatterns
{
    public class Menu : MenuComponent
    {
        private List<MenuComponent> _menuComponents = new List<MenuComponent>();
        private string _name;
        private string _description;
        public Menu()
        {

        }
        // other methods here
        public void Print()
        {
            Console.WriteLine("\n" + GetName());
            Console.WriteLine(", " + GetDescription());
            Console.WriteLine("---------------------");

            foreach(MenuComponent menuComponent in _menuComponents)
            {
                menuComponent.Print();
            }
        }
    }
}
