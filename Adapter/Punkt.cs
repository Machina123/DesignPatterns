using System;

namespace Adapter
{
    public class Punkt : Figura
    {
        
        public void Wyswietl()
        {
            Console.WriteLine("Rysuje punkt");
        }

        public void Wypelnij()
        {
            throw new NotImplementedException();
        }

        public void Usun()
        {
            throw new NotImplementedException();
        }
    }
}