using System;

namespace Decorator
{
    public class Naglowek2 : Dekorator
    {
        public Naglowek2(Komponent mojKomponent) : base(mojKomponent)
        {
        }

        public override void Drukuj()
        {
            Console.WriteLine("Nagłówek 2");
            base.Drukuj();
        }
    }
}