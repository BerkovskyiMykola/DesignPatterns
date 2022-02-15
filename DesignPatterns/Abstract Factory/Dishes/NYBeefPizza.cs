namespace DesignPatterns.Abstract_Factory.Dishes
{
    internal class NYBeefPizza : Pizza
    {
        public NYBeefPizza()
        {
            Name = "NY Beef pizza";
        }
        public override void Prepare()
        {
            Console.WriteLine(Name + " is being prepared");
        }
    }
}
