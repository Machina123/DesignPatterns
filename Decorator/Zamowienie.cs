using System;

namespace Decorator
{
    public class Zamowienie
    {
        public void Drukuj()
        {
            Komponent potwierdzenie1 = Konfiguracja.PobierzPotwierdzenieDwaNaglowki();
            potwierdzenie1.Drukuj();
            Console.WriteLine("");
            Komponent potwierdzenie2 = Konfiguracja.PobierzPotwierdzenieDwieStopki();
            potwierdzenie2.Drukuj();
        }
    }
}