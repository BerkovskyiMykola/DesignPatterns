namespace DesignPatterns.Iterator.Iterators
{
    internal interface IIterator
    {
        bool HasNext();
        MenuItem Next();
    }
}
