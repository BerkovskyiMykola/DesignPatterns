using DesignPatterns.State.States;

namespace DesignPatterns.State
{
    internal class GumBallMachine
    {
        public IState HasQuarterState { get; set; }
        public IState SoldOutState { get; set; }
        public IState NoQuarterState { get; set; }
        public IState SoldState { get; set; }
        public IState State { get; set; }
        public int Count { get; set; } = 0;

        public GumBallMachine(int count)
        {
            HasQuarterState = new HasQuarterState(this);
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            SoldState = new SoldState(this);
            State = SoldOutState;
            if (count > 0)
            {
                State = NoQuarterState;
            }
            Count = count;
        }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }
        public void EjectQuarter()
        {
            State.EjectQuarter();
        }
        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();

        }

        public void Release()
        {
            Console.WriteLine("A gumball comes rolling out the slot ...");
            if (Count != 0)
            {
                Count--;
            }
        }
    }
}