namespace DesignPatterns.Observer.Interfaces
{
    internal interface IObservable
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
