using DesignPatterns.State_and_Proxy;

namespace DesignPatterns.State_and_Proxy
{
    internal class GumBallMonitor
    {
        GumBallMachine machine;
        public GumBallMonitor(GumBallMachine machine)
        {
            this.machine = machine;
        }

        public void Report()
        {
            Console.WriteLine("Gumball Machine: " + machine.Location);
            Console.WriteLine("Current inventory: " + machine.Count + " gumballs");
            Console.WriteLine("Current state: " + machine.State);
        }
    }
}
