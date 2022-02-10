using DesignPatterns.Strategy.Abilities;

namespace DesignPatterns.Strategy.Ducks
{
    internal class ModelDuck : Duck
    {
        public ModelDuck()
        {
            Flyable = new FlyNoWay();
            Quackable = new UsualQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a model duck");
        }
    }
}
