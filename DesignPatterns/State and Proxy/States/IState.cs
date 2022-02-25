namespace DesignPatterns.State_and_Proxy
{
    internal interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}
