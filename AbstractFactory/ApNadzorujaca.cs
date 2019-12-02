namespace AbstractFactory
{
    public class ApNadzorujaca
    {
        private FabrykaSterownikow _fabryka;

        public ApNadzorujaca(FabrykaSterownikow fabryka)
        {
            _fabryka = fabryka;
        }
        
        public void Dzialaj()
        {
            SterownikDrukarki sterownikDrukarki = _fabryka.PobierzSterownikDrukarki();
            SterownikEkranu sterownikEkranu = _fabryka.PobierzSterownikEkranu();
            sterownikDrukarki.Drukuj();
            sterownikEkranu.Rysuj();
        }        
    }
}