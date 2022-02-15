namespace DesignPatterns.Abstract_Factory.Dishes
{
    internal class NYCheesePizza : Pizza
    {
        public NYCheesePizza()
        {
            Name = "NY Cheese pizza";
        }
        public override void Prepare()
        {
            Console.WriteLine(Name + " is being prepared");
        }
    }
}
