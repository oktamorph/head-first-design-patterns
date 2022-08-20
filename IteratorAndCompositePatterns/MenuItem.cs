namespace IteratorAndCompositePatterns
{
    public class MenuItem
    {
        private readonly string _name;
        private readonly string _description;
        private readonly double _price;
        private readonly bool _vegetarian;        
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
