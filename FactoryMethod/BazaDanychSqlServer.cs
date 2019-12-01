using System;

namespace FactoryMethod
{
    public class BazaDanychSqlServer : BazaDanych
    {
        public override void Polacz(string Adres)
        {
            Console.WriteLine($"Połączono z bazą danych SQL Server: {Adres}");
        }

        public override void WykonajSelect(string Zapytanie)
        {
            Console.WriteLine($"SQL Server >>> {Zapytanie}\n\tZapytanie wykonane pomyslnie");
        }
    }
}