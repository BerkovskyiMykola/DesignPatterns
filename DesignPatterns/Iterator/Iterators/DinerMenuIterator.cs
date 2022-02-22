namespace DesignPatterns.Iterator.Iterators
{
    internal class DinerMenuIterator : IIterator
    {
        MenuItem[] items;
        int position = 0;
        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }
        public MenuItem Next()
        {
            MenuItem menuItem = items[position];
            position = position + 1;
            return menuItem;
        }
        public bool HasNext()
        {
            if (position >= items.Length || items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
