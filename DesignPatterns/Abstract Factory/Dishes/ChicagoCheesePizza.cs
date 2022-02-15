namespace DesignPatterns.Abstract_Factory.Dishes
{
    internal class ChicagoCheesePizza : Pizza
    {
        public ChicagoCheesePizza()
        {
            Name = "Chicago Cheese pizza";
        }
        public override void Prepare()
        {
            Console.WriteLine(Name + " is being prepared");
        }
    }
}
