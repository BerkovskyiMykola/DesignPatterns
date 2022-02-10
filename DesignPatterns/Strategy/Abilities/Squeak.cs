using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Abilities
{
    internal class Squeak : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("I am squeaking!");
        }
    }
}
