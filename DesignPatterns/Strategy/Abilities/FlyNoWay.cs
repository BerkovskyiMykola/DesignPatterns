using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Abilities
{
    internal class FlyNoWay : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I can not fly!");
        }
    }
}
