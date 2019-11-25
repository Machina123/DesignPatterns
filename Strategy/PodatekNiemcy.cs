namespace Strategy
{
    public class PodatekNiemcy : ObliczPodatek
    {
        public double KwotaPodatku(double kwotaNetto)
        {
            return kwotaNetto * 0.15d;
        }
    }
}