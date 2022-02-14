namespace DesignPatterns.Decorator.Beverages
{
    internal class HouseBlend : Beverage
    {
        public HouseBlend() : base("House Blend Coffee") { }

        public override double Cost() => .89;
    }
}
