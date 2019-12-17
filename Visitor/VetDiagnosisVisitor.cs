using System;

namespace Visitor
{
    public class VetDiagnosisVisitor : Visitor
    {
        public void VisitAnimal(Animal a)
        {
            string diagnosis = "", treatment = "";
            if (a.IsHealthy)
            {
                diagnosis = "zdrowy";
                treatment = "niewymagane";
            }
            else
            {
                diagnosis = "choroba";
                treatment = "antybiotyki";
            }
            Console.WriteLine($"Odwiedzone zwierzę: {a.Type}. Diagnoza: {diagnosis}. Leczenie: {treatment}");
        }

        public void VisitBird(Bird b)
        {
            string diagnosis = "", treatment = "";
            if (b.IsHealthy)
            {
                diagnosis = "zdrowy";
                treatment = "niewymagane";
            }
            else
            {
                diagnosis = "choroba";
                if (b.BlackmarketPrice >= 2 * b.Price) treatment = "klinika";
                else treatment = "antybiotyki, dieta";

            }
            Console.WriteLine($"Odwiedzone zwierzę: {b.Type}. Diagnoza: {diagnosis}. Leczenie: {treatment}");
        }
    }
}