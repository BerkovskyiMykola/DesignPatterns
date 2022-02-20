namespace DesignPatterns.Facade.Subsystems
{
    internal class CLR
    {
        public void Execute()
        {
            Console.WriteLine("Application execution");
        }
        public void Finish()
        {
            Console.WriteLine("Terminate the application");
        }
    }
}
