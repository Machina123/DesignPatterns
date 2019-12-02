using System;

namespace Decorator
{
    public class Naglowek1 : Dekorator
    {
        public Naglowek1(Komponent mojKomponent) : base(mojKomponent)
        {
        }

        public override void Drukuj()
        {
            Console.WriteLine("Nagłówek 1");
            base.Drukuj();
        }
        
    }
}