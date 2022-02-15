namespace DesignPatterns.Abstract_Factory.Dishes
{
    internal abstract class Pizza
    {
        public string Name { get; protected set; } = string.Empty;
        public abstract void Prepare();
        public void Bake()
        {
            Console.WriteLine(Name + " baking");
        }
        public void Cut()
        {
            Console.WriteLine(Name + " cutting");
        }
        public void Box()
        {
            Console.WriteLine(Name + " boxing");
        }
    }
}
