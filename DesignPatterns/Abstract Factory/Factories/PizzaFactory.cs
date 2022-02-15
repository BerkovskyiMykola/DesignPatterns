using DesignPatterns.Abstract_Factory.Dishes;

namespace DesignPatterns.Abstract_Factory.Factories
{
    internal abstract class PizzaFactory
    {
        public abstract Pizza CreatePizza(string name);
    }
}
