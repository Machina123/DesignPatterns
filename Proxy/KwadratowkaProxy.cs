using System;

namespace Proxy
{
    public class KwadratowkaProxy
    {
        private double _a, _b, _c, _x, _wynik;
        
        public double Rozwiaz(double a, double b, double c, double x)
        {
            if (!(a == _a && b == _b && c == _c && _x == _x))
            {
                Console.WriteLine("Przekazywanie zadania do klasy Kwadratowka...");
                _a = a;
                _b = b;
                _c = c;
                _x = x;
                _wynik = Kwadratowka.Rozwiaz(a, b, c, x);
            }
            else
            {
                Console.WriteLine("Pobieranie wyniku zapamiętanego przez KwadratowkaProxy...");
            }
            return _wynik;
        }
    }
}