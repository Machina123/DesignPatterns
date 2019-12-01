namespace FactoryMethod
{
    public abstract class BazaDanych
    {
        public abstract void Polacz(string Adres);

        public abstract void WykonajSelect(string Zapytanie);
    }
}