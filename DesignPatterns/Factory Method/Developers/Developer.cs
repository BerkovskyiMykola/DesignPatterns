using DesignPatterns.Factory_Method.Houses;

namespace DesignPatterns.Factory_Method.Developers
{
    internal abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string n)
        {
            Name = n;
        }
        //Factory Method
        abstract public House Create();
    }
}
