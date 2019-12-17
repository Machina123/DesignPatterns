namespace Visitor
{
    public abstract class Animal
    {
        public double Price { get; private set; }
        public bool IsHealthy { get; private set; }
        public string Type { get; private set; }

        public Animal(double price, bool isHealthy, string type)
        {
            Price = price;
            IsHealthy = isHealthy;
            Type = type;
        }

        public abstract void Accept(Visitor v);

        public override string ToString()
        {
            return $"Zwierzę: {Type}; Cena: {Price}; Zdrowe? {(IsHealthy ? "Tak" : "Nie")}; ";
        }
    }
}