namespace DesignPatterns.Command
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
