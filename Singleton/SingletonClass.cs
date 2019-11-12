using System;

namespace Singleton
{
    public sealed class SingletonClass
    {
        private static SingletonClass _instance = null;

        private SingletonClass()
        {
            Console.WriteLine("Inicjalizacja Singletona");
        }

        public static SingletonClass GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonClass();
            }
           
            return _instance;
        }

        public void Talk()
        {
            Console.WriteLine("Ja gadam!");
        }

        public void WhoAmI()
        {
            Console.WriteLine("I am Singleton!");
        }
    }
}