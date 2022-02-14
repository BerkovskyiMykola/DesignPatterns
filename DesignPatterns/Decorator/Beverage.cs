namespace DesignPatterns.Decorator
{
    internal abstract class Beverage
    {
        public string Name { get; protected set; }

        public Beverage(string n)
        {
            Name = n;
        }

        public abstract double Cost();
    }
}
