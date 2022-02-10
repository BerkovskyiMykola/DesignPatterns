using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Abilities
{
    internal class MuteQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("I can not quack!");
        }
    }
}
