namespace Bridge
{
    public class Okrag : Figura
    {
        private double _x, _y, _r;

        public Okrag(Biblioteka bg, double x, double y, double r) : base(bg)
        {
            this._x = x;
            this._y = y;
            this._r = r;
        }

        public override void Rysuj()
        {
            RysujOkrag(_x, _y, _r);
        }
    }
}