namespace DesignPatterns.Decorator.Decorators
{
    internal class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage.Name + ", Milk", beverage) { }

        public override double Cost()
        {
            return beverage.Cost() + .45;
        }
    }
}
