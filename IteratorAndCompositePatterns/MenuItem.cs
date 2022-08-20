namespace IteratorAndCompositePatterns
{
    public class MenuItem
    {
        private string _name;
        private string _description;
        private double _price;
        private bool _vegetarian;        
        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this._name = name;
            this._description = description;
            this._vegetarian = vegetarian;
            this._price = price;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetDescription()
        {
            return _description;
        }
        public double GetPrice()
        {
            return _price;
        }
        public bool IsVegetarian()
        {
            return _vegetarian;
        }
    }
}
