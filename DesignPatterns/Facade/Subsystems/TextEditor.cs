namespace DesignPatterns.Facade.Subsystems
{
    internal class TextEditor
    {
        public void CreateCode()
        {
            Console.WriteLine("Code writing");
        }
        public void Save()
        {
            Console.WriteLine("Saving code");
        }
    }
}
