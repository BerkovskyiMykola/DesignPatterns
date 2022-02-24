namespace DesignPatterns.State.States
{
    internal class HasQuarterState : IState
    {
        GumBallMachine gumBallMachine;
        public HasQuarterState(GumBallMachine gumBallMachine)
        {
            this.gumBallMachine = gumBallMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumBallMachine.State = gumBallMachine.NoQuarterState;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can not inserted another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...... ");
            gumBallMachine.State = gumBallMachine.SoldState;
        }
    }
}
