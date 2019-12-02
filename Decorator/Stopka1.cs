using System;

namespace Decorator
{
    public class Stopka1 : Dekorator
    {
        public Stopka1(Komponent mojKomponent) : base(mojKomponent)
        {
        }

        public override void Drukuj()
        {
            base.Drukuj();
            Console.WriteLine("Stopka 1");
        }
    }
}