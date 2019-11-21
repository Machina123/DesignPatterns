using System;

namespace Bridge
{
    public class BG2
    {
        public static void NarysujLinie(double x1, double x2, double y1, double y2)
        {
            Console.WriteLine($"Rysuje linie - BG2 - {x1} {x2} {y1} {y2}");
        }

        public static void NarysujOkrag(double x, double y, double r)
        {
            Console.WriteLine($"Rysuje okrag - BG2 - {x} {y} {r}");
        }
    }
}