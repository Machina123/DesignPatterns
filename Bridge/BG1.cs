using System;

namespace Bridge
{
    public class BG1
    {
        public static void rysuj_linie(double x1, double x2, double y1, double y2)
        {
            Console.WriteLine($"Rysuje linie - BG1 - {x1} {x2} {y1} {y2}");
        }

        public static void rysuj_okrag(double x, double y, double r)
        {
            Console.WriteLine($"Rysuje okrag - BG1 - {x} {y} {r}");
        }
    }
}