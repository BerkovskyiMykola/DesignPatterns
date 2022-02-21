namespace DesignPatterns.Template_Method
{
    internal abstract class CaffeineBeverage : Preparing
    {
        public sealed override void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }
        public abstract void Brew();
        public abstract void AddCondiments();
        public virtual void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        public virtual void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }

    abstract class Preparing
    {
        public abstract void PrepareRecipe();
    }
}
