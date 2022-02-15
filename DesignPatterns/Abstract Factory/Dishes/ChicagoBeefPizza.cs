namespace DesignPatterns.Abstract_Factory.Dishes
{
    internal class ChicagoBeefPizza : Pizza
    {
        public ChicagoBeefPizza()
        {
            Name = "Chicago Beef pizza";
        }
        public override void Prepare()
        {
            Console.WriteLine(Name + " is being prepared");
        }
    }
}
