using System;

namespace Decorator
{
    public class Potwierdzenie : Komponent
    {
        public void Drukuj()
        {
            Console.WriteLine("Potwierdzenie");
        }
    }
}