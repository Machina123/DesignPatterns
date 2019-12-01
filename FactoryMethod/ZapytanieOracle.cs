namespace FactoryMethod
{
    public class ZapytanieOracle : SzablonZapytania
    {
        protected override string FormatujConnect(string NazwaBazy)
        {
            return $"oracle:thin:@{NazwaBazy}";
        }

        protected override string FormatujSelect(string Zapytanie)
        {
            return Zapytanie + ";";
        }

        public override BazaDanych UtworzBazeDanych()
        {
            return new BazaDanychOracle();
        }
    }
}