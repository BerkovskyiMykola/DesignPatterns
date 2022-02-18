namespace DesignPatterns.Command.Receivers
{
    internal class Light
    {
        public void On()
        {
            Console.WriteLine("Light is ON!");
        }

        public void Off()
        {
            Console.WriteLine("Light is OFF!");
        }
    }
}
