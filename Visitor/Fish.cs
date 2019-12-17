namespace Visitor
{
    public class Fish : Animal
    {
        public Fish(double price, bool isHealthy) : base(price, isHealthy, "ryba")
        {
        }

        public override void Accept(Visitor v)
        {
            v.VisitAnimal(this);
        }
    }
}