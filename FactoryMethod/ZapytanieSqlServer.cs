namespace FactoryMethod
{
    public class ZapytanieSqlServer : SzablonZapytania
    {
        protected override string FormatujConnect(string NazwaBazy)
        {
            return $"sqlserver://{NazwaBazy}:1433";
        }

        protected override string FormatujSelect(string Zapytanie)
        {
            return Zapytanie;
        }

        public override BazaDanych UtworzBazeDanych()
        {
            return new BazaDanychSqlServer();
        }
    }
}