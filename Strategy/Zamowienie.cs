using System;
using System.Text;

namespace Strategy
{
    public class Zamowienie
    {
        private double[] _towary;
        private ObliczPodatek _podatek; 

        public Zamowienie(double[] towary, Kraj kraj)
        {
            this._towary = towary;
            this._podatek = Konfiguracja.WyborStrategii(kraj);
        }

        public void ObliczPodatek()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Towar\tCena brutto");
            for (int i = 0; i < _towary.Length; i++)
            {
                sb.AppendLine($"{i + 1}\t{_towary[i] + _podatek.KwotaPodatku(_towary[i])}");
            }
            Console.WriteLine(sb);
        }
    }
}