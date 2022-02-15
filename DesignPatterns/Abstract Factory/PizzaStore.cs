using DesignPatterns.Abstract_Factory.Dishes;
using DesignPatterns.Abstract_Factory.Factories;

namespace DesignPatterns.Abstract_Factory
{
    //In theory we can create concreate pizza store (NYPizzaStore or ChicagoPizzaStore for example)
    //For it you need make this class abstract, delete instance _pizzaFactory
    //Create abstract method CreatePizza and in derived classes override CreatePizza
    internal class PizzaStore
    {
        private PizzaFactory _pizzaFactory;

        public PizzaStore(PizzaFactory pizzaFactory)
        {
            _pizzaFactory = pizzaFactory;
        }

        public Pizza OrderPizza(string name)
        {
            Pizza pizza = _pizzaFactory.CreatePizza(name);
            pizza?.Prepare();
            pizza?.Bake();
            pizza?.Cut();
            pizza?.Box();
            return pizza;
        }
    }
}
