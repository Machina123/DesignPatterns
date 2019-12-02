namespace AbstractFactory
{
    public class FabrykaWysRozdz : FabrykaSterownikow
    {
        public override SterownikEkranu PobierzSterownikEkranu()
        {
            return new SterownikEkranuWysRozdz();
        }

        public override SterownikDrukarki PobierzSterownikDrukarki()
        {
            return new SterownikDrukarkiWysRozdz();
        }
    }
}