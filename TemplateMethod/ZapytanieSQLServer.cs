namespace TemplateMethod
{
    public class ZapytanieSQLServer : SzablonZapytania
    {
        protected override string FormatujConnect(string NazwaBazy)
        {
            return $"sqlserver://{NazwaBazy}:1433";
        }

        protected override string FormatujSelect(string Zapytanie)
        {
            return Zapytanie;
        }
    }
}