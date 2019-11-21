namespace Bridge
{
    public class Prostokat : Figura
    {
        private double _x1, _x2, _y1, _y2;
        
        public Prostokat(Biblioteka bg, double x1, double x2, double y1, double y2) : base(bg)
        {
            this._x1 = x1;
            this._x2 = x2;
            this._y1 = y1;
            this._y2 = y2;
        }

        public override void Rysuj()
        {
            RysujLinie(_x1, _x2, _y1, _y1);
            RysujLinie(_x2, _x2, _y1, _y2);
            RysujLinie(_x2, _x1, _y2, _y2);
            RysujLinie(_x1, _x1, _y2, _y1);
        }
    }
}