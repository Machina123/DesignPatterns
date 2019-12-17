using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals =
            {
                new Bird(120, 250, false),
                new Fish(100, true),
                new Mammal(180, false),
                new Reptile(300, true),
                new Bird(180, 260, false)
            };
            Console.WriteLine("---- KOLEKCJA ----");
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal}");
            }
            Console.WriteLine("\n---- WIZYTACJA ----");
            OfficialPriceSumVisitor officialPriceSumVisitor = new OfficialPriceSumVisitor();
            BlackmarketPriceSumVisitor blackmarketPriceSumVisitor = new BlackmarketPriceSumVisitor();
            VetDiagnosisVisitor vetDiagnosisVisitor = new VetDiagnosisVisitor();


            foreach (var animal in animals)
            {
                animal.Accept(officialPriceSumVisitor);
                animal.Accept(blackmarketPriceSumVisitor);
            }

            officialPriceSumVisitor.PrintVisitResult();
            blackmarketPriceSumVisitor.PrintVisitResult();

            foreach (var animal in animals)
            {
                animal.Accept(vetDiagnosisVisitor);
            }
        }
    }
}