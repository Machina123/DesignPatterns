using System;

namespace Adapter
{
    public class Kwadrat : Figura
    {
        
        public void Wyswietl()
        {
            Console.WriteLine("Rysuje kwadrat");
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