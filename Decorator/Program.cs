using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Zamowienie zamowienie = new Zamowienie();
            zamowienie.Drukuj();
        }
    }
}