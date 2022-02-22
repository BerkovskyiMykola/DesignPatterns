namespace DesignPatterns.Iterator.Iterators
{
    internal class PancakeHouseMenuIterator : IIterator
    {
        List<MenuItem> items;
        int position = 0;
        public PancakeHouseMenuIterator(List<MenuItem> items)
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
            return position < items.Count;
        }
    }
}
