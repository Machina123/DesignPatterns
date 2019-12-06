using System;

namespace Proxy
{
    public class Kwadratowka
    {
        public Wynik Rozwiaz(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            Wynik w = new Wynik();
            w.X1 = (-1 * b - Math.Sqrt(delta)) / 2 * a;
            w.X2 = (-1 * b + Math.Sqrt(delta)) / 2 * a;
            return w;
        }
    }
}