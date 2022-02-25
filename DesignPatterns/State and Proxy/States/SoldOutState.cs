namespace DesignPatterns.State_and_Proxy.States
{
    internal class SoldOutState : IState
    {
        GumBallMachine gumBallMachine;
        public SoldOutState(GumBallMachine gumBallMachine)
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
            Console.WriteLine("You can not inserted a quarrter");
            gumBallMachine.State = gumBallMachine.SoldState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turn ,but there is no quarter");
        }
    }
}
