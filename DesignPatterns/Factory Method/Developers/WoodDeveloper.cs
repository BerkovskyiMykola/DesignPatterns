using DesignPatterns.Factory_Method.Houses;

namespace DesignPatterns.Factory_Method.Developers
{
    internal class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new WoodHouse();
        }
    }
}
