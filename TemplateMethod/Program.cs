using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string query = "SELECT * FROM Users";
            Console.WriteLine("Zapytanie do SQL Server");
            SzablonZapytania zapytanie1 = new ZapytanieSQLServer();
            zapytanie1.WykonajZapytanie("sql-prod-1", query);
            
            Console.WriteLine("\nZapytanie do Oracle");
            SzablonZapytania zapytanie2 = new ZapytanieOracle();
            zapytanie2.WykonajZapytanie("oracle-prod-1", query);
        }
    }
}