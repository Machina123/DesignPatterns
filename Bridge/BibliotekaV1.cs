namespace Bridge
{
    public class BibliotekaV1 : Biblioteka
    {
        public void RysujLinie(double x1, double x2, double y1, double y2)
        {
            BG1.rysuj_linie(x1, x2, y1, y2);
        }

        public void RysujOkrag(double x, double y, double r)
        {
            BG1.rysuj_okrag(x, y, r);
        }
    }
}