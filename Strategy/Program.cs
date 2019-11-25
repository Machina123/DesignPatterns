using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] produkty = {12.3, 4.56, 7.80, 9.00, 10.11, 23.45, 6.7, 8.9};
            Zamowienie zamowienie1 = new Zamowienie(produkty, Kraj.Polska);
            zamowienie1.ObliczPodatek();

            Zamowienie zamowienie2 = new Zamowienie(produkty, Kraj.Niemcy);
            zamowienie2.ObliczPodatek();
        }
    }
}