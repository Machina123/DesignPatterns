using System;

namespace FactoryMethod
{
    public abstract class SzablonZapytania
    {
        public void WykonajZapytanie(string NazwaBazy, string Zapytanie)
        {
            string komenda;
            BazaDanych baza = UtworzBazeDanych();
            
            komenda = FormatujConnect(NazwaBazy);
            // tutaj łączenie z bazą...
            baza.Polacz(komenda);

            komenda = FormatujSelect(Zapytanie);
            // tutaj wykonanie zapytania...
            baza.WykonajSelect(komenda);
            
            // tutaj zwracanie wyniku zapytania...
        }
        
        protected abstract string FormatujConnect(string NazwaBazy);

        protected abstract string FormatujSelect(string Zapytanie);

        public abstract BazaDanych UtworzBazeDanych();
    }
}