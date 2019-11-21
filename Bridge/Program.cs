using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteka bg1 = new BibliotekaV1();
            Biblioteka bg2 = new BibliotekaV2();
            Figura f1 = new Prostokat(bg1, 1, 2, 3, 4);
            Figura f2 = new Okrag(bg2, 2, 2, 4);
            
            f1.Rysuj();
            f2.Rysuj();
        }
    }
}