namespace DesignPatterns.Command
{
    // Можна зробити контролер з багатьох команд. Для цього необхідно просто створити List команд і оброблювати їх логіку
    internal class SimpleRemoteControl
    {
        ICommand _command;

        public SimpleRemoteControl() { }

        public void SetCommand(ICommand com)
        {
            _command = com;
        }

        public void ButtonWasPressed()
        {
            _command.Execute();
        }

        public void UndoWasPressed()
        {
            _command.Undo();
        }
    }
}
