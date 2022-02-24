namespace DesignPatterns.State.States
{
    internal class NoQuarterState : IState
    {
        GumBallMachine gumBallMachine;
        public NoQuarterState(GumBallMachine gumBallMachine)
        {
            this.gumBallMachine = gumBallMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You have not inserted a quarter");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumBallMachine.State = gumBallMachine.HasQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turn ,but there is no quarter");
        }
    }
}
