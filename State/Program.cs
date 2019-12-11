using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            File plik = new File();
            plik.Open();
            plik.Open();
            plik.Read();
            plik.Write();
            plik.Close();
            plik.Read();
        }
    }
}