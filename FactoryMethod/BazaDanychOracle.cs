using System;

namespace FactoryMethod
{
    public class BazaDanychOracle : BazaDanych
    {
        public override void Polacz(string Adres)
        {
            Console.WriteLine($"Polaczono z baza danych Oracle: {Adres}");
        }

        public override void WykonajSelect(string Zapytanie)
        {
            Console.WriteLine($"Oracle >>> {Zapytanie}\n\tZapytanie wykonano pomyslnie");
        }
    }
}