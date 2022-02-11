namespace DesignPatterns.Observer.Interfaces
{
    internal interface IObserver
    {
        void Update(int temp, int humidity, int pressure);
    }
}
