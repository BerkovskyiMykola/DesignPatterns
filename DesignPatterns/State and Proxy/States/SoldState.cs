namespace DesignPatterns.State_and_Proxy.States
{
    internal class SoldState : IState
    {
        GumBallMachine gumBallMachine;
        public SoldState(GumBallMachine gumBallMachine)
        {
            this.gumBallMachine = gumBallMachine;
        }

        public void Dispense()
        {
            gumBallMachine.Release();
            if (gumBallMachine.Count > 0)
            {
                gumBallMachine.State = gumBallMachine.NoQuarterState;
            }
            else
            {
                Console.WriteLine("Oops,out of gumballs!");
                gumBallMachine.State = gumBallMachine.SoldOutState;
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry,you already turned the carnk");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("please wait,we are already giving you a gumball");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice does not get you another gumball");
        }
    }
}
