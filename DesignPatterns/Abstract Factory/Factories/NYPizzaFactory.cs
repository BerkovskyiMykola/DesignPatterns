using DesignPatterns.Abstract_Factory.Dishes;

namespace DesignPatterns.Abstract_Factory.Factories
{
    internal class NYPizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza(string name)
        {
            if (name == "cheese")
            {
                return new NYCheesePizza();
            }
            else if (name == "beef")
            {
                return new NYBeefPizza();
            }
            return null;
        }
    }
}
