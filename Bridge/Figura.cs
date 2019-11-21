namespace Bridge
{
    public abstract class Figura
    {
        private Biblioteka _bg;

        public Figura(Biblioteka bg)
        {
            this._bg = bg;
        }
        
        public abstract void Rysuj();

        protected void RysujLinie(double x1, double x2, double y1, double y2)
        {
            _bg.RysujLinie(x1, x2, y1, y2);
        }

        protected void RysujOkrag(double x, double y, double r)
        {
            _bg.RysujOkrag(x, y, r);
        }
    }
}