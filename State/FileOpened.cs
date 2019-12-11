using System;

namespace State
{
    public sealed class FileOpened : FileState
    {
        private static FileOpened _instance = null;
        private File _context = null;

        private FileOpened()
        {
        }

        public static FileState GetInstance()
        {
            if(_instance == null) _instance = new FileOpened();
            return _instance;
        }

        public void Open()
        {
            Console.WriteLine("Plik już jest otwarty");
        }

        public void Close()
        {
            Console.WriteLine("Zamykam plik");
            _context.ChangeState(FileClosed.GetInstance());
        }

        public void Read()
        {
            Console.WriteLine("Odczytuję plik");
        }

        public void Write()
        {
            Console.WriteLine("Zapisuję do pliku");
        }

        public void SetContext(File ctx)
        {
            _context = ctx;
        }
    }
}