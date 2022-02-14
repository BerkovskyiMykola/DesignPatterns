namespace DesignPatterns.Decorator.Decorators
{
    internal abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;
        public CondimentDecorator(string n, Beverage beverage) : base(n)
        {
            this.beverage = beverage;
        }
    }
}
