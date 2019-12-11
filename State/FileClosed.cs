using System;

namespace State
{
    public class FileClosed : FileState
    {
        private static FileClosed _instance = null;
        private File _context = null;

        private FileClosed()
        {
        }

        public static FileState GetInstance()
        {
            if(_instance == null) _instance = new FileClosed();
            return _instance;
        }

        public void Open()
        {
            Console.WriteLine("Otwieram plik");
            _context.ChangeState(FileOpened.GetInstance());
        }

        public void Close()
        {
            Console.WriteLine("Plik już jest zamknięty");
        }

        public void Read()
        {
            Console.WriteLine("Plik zamknięty - odczyt niemożliwy");
        }

        public void Write()
        {
            Console.WriteLine("Plik zamknięty - zapis niemożliwy");
        }

        public void SetContext(File ctx)
        {
            _context = ctx;
        }
    }
}