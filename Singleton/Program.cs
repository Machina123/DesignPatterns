using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClass singleton1 = SingletonClass.GetInstance();
            singleton1.Talk();
            singleton1.WhoAmI();
            SingletonClass singleton2 = SingletonClass.GetInstance();
            singleton2.Talk();
            singleton2.WhoAmI();
        }
    }
}