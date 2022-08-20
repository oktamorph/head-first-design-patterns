namespace IteratorAndCompositePatterns
{
    public class DinerMenuIterator : Iterator<MenuItem>
    {
        private readonly MenuItem[] _items;
        private int _position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this._items = items;
        }
        public MenuItem Next()
        {
            MenuItem menuItem = _items[_position];
            _position = _position + 1;
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
            throw new InvalidOperationException("You shouldn't be trying to remove menu items.");
        }
    }
}
