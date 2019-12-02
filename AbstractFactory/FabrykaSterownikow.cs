namespace AbstractFactory
{
    public abstract class FabrykaSterownikow
    {
        public abstract SterownikEkranu PobierzSterownikEkranu();

        public abstract SterownikDrukarki PobierzSterownikDrukarki();
    }
}