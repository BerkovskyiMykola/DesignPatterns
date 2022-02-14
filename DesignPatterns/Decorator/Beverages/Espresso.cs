namespace DesignPatterns.Decorator.Beverages
{
    internal class Espresso : Beverage
    {
        public Espresso() : base("Espresso") { }

        public override double Cost() => 1.99;
    }
}
