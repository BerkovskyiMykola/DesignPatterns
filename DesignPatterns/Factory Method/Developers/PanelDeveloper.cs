using DesignPatterns.Factory_Method.Houses;

namespace DesignPatterns.Factory_Method.Developers
{
    internal class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
}
