namespace DesignPatterns.Adapter.Ducks
{
    internal class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Quack");
        }

        public void Quack()
        {
            Console.WriteLine("I’m flying");
        }
    }
}
