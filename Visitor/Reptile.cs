namespace Visitor
{
    public class Reptile : Animal
    {
        public Reptile(double price, bool isHealthy) : base(price, isHealthy, "gad")
        {
        }

        public override void Accept(Visitor v)
        {
            v.VisitAnimal(this);
        }
    }
}