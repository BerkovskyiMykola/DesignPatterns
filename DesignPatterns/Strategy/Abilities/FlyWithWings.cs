using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Abilities
{
    internal class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!");
        }
    }
}
