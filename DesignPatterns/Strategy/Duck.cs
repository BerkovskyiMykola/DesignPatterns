using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy
{
    internal abstract class Duck
    {
        public IQuackable Quackable { private get; set; } = null!;
        public IFlyable Flyable { private get; set; } = null!;

        public void Quack()
        {
            Quackable.Quack();
        }

        public void Fly()
        {
            Flyable.Fly();
        }

        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
