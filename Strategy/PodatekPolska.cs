namespace Strategy
{
    public class PodatekPolska : ObliczPodatek
    {
        public double KwotaPodatku(double kwotaNetto)
        {
            return kwotaNetto * 0.23d;
        }
    }
}