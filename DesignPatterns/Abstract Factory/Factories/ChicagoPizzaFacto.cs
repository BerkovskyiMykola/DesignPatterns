using DesignPatterns.Abstract_Factory.Dishes;

namespace DesignPatterns.Abstract_Factory.Factories
{
    internal class ChicagoPizzaFacto : PizzaFactory
    {
        public override Pizza CreatePizza(string name)
        {
            if (name == "cheese")
            {
                return new ChicagoCheesePizza();
            }
            else if(name == "beef")
            {
                return new ChicagoBeefPizza();
            }
            return null;
        }
    }
}
