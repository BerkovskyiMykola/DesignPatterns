namespace DesignPatterns.Iterator
{
    internal class MenuItem
    {
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public bool Vegetarian { get; private set; }
        public double Price { get; private set; }

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }
    }
}
