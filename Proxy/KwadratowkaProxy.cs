using System;

namespace Proxy
{
    public class KwadratowkaProxy
    {
        private double _a, _b, _c;
        private Wynik _wynik;
        private Kwadratowka _solver;

        public KwadratowkaProxy()
        {
            _solver = new Kwadratowka();
        }

        public Wynik Rozwiaz(double a, double b, double c)
        {
            if (!(a.Equals(_a) && b.Equals(_b) && c.Equals(_c)))
            {
                Console.WriteLine("Proxy: Przekazywanie zadania do klasy Kwadratowka...");
                _a = a;
                _b = b;
                _c = c;
                _wynik = _solver.Rozwiaz(a, b, c);
            }
            else
            {
                Console.WriteLine("Proxy: Pobieranie wyniku zapamiętanego przez KwadratowkaProxy...");
            }
            return _wynik;
        }
    }
}