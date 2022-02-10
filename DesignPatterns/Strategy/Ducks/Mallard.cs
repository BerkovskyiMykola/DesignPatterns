using DesignPatterns.Strategy.Abilities;

namespace DesignPatterns.Strategy.Ducks
{
    internal class Mallard : Duck
    {
        public Mallard()
        {
            Quackable = new UsualQuack();
            Flyable = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I’m a real Mallard duck");
        }
    }
}
