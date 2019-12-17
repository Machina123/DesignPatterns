using System;

namespace Visitor
{
    public class OfficialPriceSumVisitor : Visitor
    {
        private double _priceSum = 0.0d;

        public void VisitAnimal(Animal a)
        {
            _priceSum += a.Price;
        }

        public void VisitBird(Bird b)
        {
            _priceSum += b.Price;
        }

        public void PrintVisitResult()
        {
            Console.WriteLine($"Suma cen zwierząt odwiedzonych przez wizytatora: {_priceSum}");
        }
    }
}