using System;

namespace TemplateMethod
{
    public abstract class SzablonZapytania
    {
        public void WykonajZapytanie(string NazwaBazy, string Zapytanie)
        {
            string komenda;
            komenda = FormatujConnect(NazwaBazy);
            // tutaj łączenie z bazą...
            Console.WriteLine(komenda);

            komenda = FormatujSelect(Zapytanie);
            // tutaj wykonanie zapytania...
            Console.WriteLine(komenda);
            
            // tutaj zwracanie wyniku zapytania...
        }

        protected abstract string FormatujConnect(string NazwaBazy);

        protected abstract string FormatujSelect(string Zapytanie);
    }
}