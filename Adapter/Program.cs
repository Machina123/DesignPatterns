using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura[] figury =
            {
                new Kwadrat(),
                new Linia(),
                new Punkt(),
                new Okrag()
            };

            foreach (var figura in figury)
            {
                figura.Wyswietl();
            }
        }
    }
}