namespace Decorator
{
    public class Dekorator : Komponent
    {
        private Komponent mojKomponent;

        public Dekorator(Komponent mojKomponent)
        {
            this.mojKomponent = mojKomponent;
        }

        public virtual void Drukuj()
        {
            if(mojKomponent != null) mojKomponent.Drukuj();
        }
    }
}