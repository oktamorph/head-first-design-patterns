namespace IteratorAndCompositePatterns
{
    internal class AlternatingDinerMenuIterator : Iterator<MenuItem>
    {
        private readonly MenuItem[] _items;
        private int _position = 0;

        public AlternatingDinerMenuIterator(MenuItem[] items)
        {
            this._items = items;
            _position = (int)DateTime.Now.DayOfWeek % 2;
        }
        public MenuItem Next()
        {
            MenuItem menuItem = _items[_position];
            _position = _position + 2;

            return menuItem;
        }
        public bool HasNext()
        {
            if (_position >= _items.Length || _items[_position] == null)
                return false;
            else
                return true;
        }
        public void Remove()
        {
            throw new InvalidOperationException("Alternating Diner Menu Iterator does not support remove().");
        }
    }
}
