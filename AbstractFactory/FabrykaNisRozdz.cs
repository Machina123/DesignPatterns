namespace AbstractFactory
{
    public class FabrykaNisRozdz : FabrykaSterownikow
    {
        public override SterownikEkranu PobierzSterownikEkranu()
        {
            return new SterownikEkranuNisRozdz();
        }

        public override SterownikDrukarki PobierzSterownikDrukarki()
        {
            return new SterownikDrukarkiNisRozdz();
        }
    }
}