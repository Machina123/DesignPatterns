namespace Decorator
{
    public class Konfiguracja
    {
        public static Komponent PobierzPotwierdzenieDwieStopki()
        {
            return new Naglowek1(new Stopka2(new Stopka1(new Potwierdzenie())));
        }

        public static Komponent PobierzPotwierdzenieDwaNaglowki()
        {
            return new Naglowek1(new Naglowek2(new Stopka1(new Potwierdzenie())));
        }
    }
}