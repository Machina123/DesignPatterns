using System;

namespace Adapter
{
    public class Okrag : Figura
    {
        private XXOkrag _xxOkrag;
        
        public Okrag(): base()
        {
            _xxOkrag = new XXOkrag();    
        }

        public void PobierzPolozenie()
        {
            _xxOkrag.PobierzPolozenie();
        }
        public void NadajPolozenie()
        {
            _xxOkrag.NadajPolozenie();
        }
        public void Wyswietl()
        {
            _xxOkrag.Wyswietlaj();
        }
        public void Wypelnij()
        {
            _xxOkrag.Wypelniaj();
        }
        public void NadajKolor() 
        {
            _xxOkrag.UstawKolor();
        }
        public void Usun()
        {
            _xxOkrag.Usuwaj();
        }
    }
}