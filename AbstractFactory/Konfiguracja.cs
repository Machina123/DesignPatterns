namespace AbstractFactory
{
    public class Konfiguracja
    {
        public static FabrykaSterownikow PobierzFabrykeNisRozdz()
        {
            return new FabrykaNisRozdz();
        }

        public static FabrykaSterownikow PobierzFabrykeWysRozdz()
        {
            return new FabrykaWysRozdz();
        }
    }
}