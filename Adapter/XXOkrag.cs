using System;

namespace Adapter
{
    public class XXOkrag
    {
        public void Wyswietlaj()
        {
            Console.WriteLine("Rysuje okrag");
        }

        public void Wypelniaj()
        {
            throw new NotImplementedException();
        }
        
        public void Usuwaj()
        {
            throw new NotImplementedException();
        }
        
        public void PobierzPolozenie()
        {
            throw new NotImplementedException();
        }
        
        public void NadajPolozenie()
        {
            throw new NotImplementedException();
        }
        
        public void UstawKolor()
        {
            throw new NotImplementedException();
        }
    }
}