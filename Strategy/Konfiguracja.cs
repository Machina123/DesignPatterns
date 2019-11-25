using System;

namespace Strategy
{
    public class Konfiguracja
    {
        public static ObliczPodatek WyborStrategii(Kraj kraj)
        {
            switch (kraj)
            {
                case Kraj.Polska:
                    return new PodatekPolska();
                case Kraj.Niemcy:
                    return new PodatekNiemcy();
                default:
                    throw new ArgumentException("Brak strategii dla wybranego kraju");
            }
        }
    }
}