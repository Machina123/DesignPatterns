namespace Visitor
{
    public class Bird : Animal
    {
        public double BlackmarketPrice { get; private set; }
        public Bird(double price, double blackmarketPrice, bool isHealthy) : base(price, isHealthy, "ptak")
        {
            BlackmarketPrice = blackmarketPrice;
        }

        public override void Accept(Visitor v)
        {
            v.VisitBird(this);
        }

        public override string ToString()
        {
            return base.ToString() + $"Cena czarnorynkowa: {BlackmarketPrice}"; 
        }
    }
}