namespace DesignPatterns.Decorator.Decorators
{
    internal class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage.Name + ", Mocha", beverage) { }

        public override double Cost()
        {
            return beverage.Cost() + .20;
        }
    }
}
