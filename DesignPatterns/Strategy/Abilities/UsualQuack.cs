using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Abilities
{
    internal class UsualQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("I am quacking!");
        }
    }
}
