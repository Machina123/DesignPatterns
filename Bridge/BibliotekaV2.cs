namespace Bridge
{
    public class BibliotekaV2 : Biblioteka
    {
        public void RysujLinie(double x1, double x2, double y1, double y2)
        {
            BG2.NarysujLinie(x1, x2, y1, y2);
        }

        public void RysujOkrag(double x, double y, double r)
        {
            BG2.NarysujOkrag(x, y, r);
        }
    }
}