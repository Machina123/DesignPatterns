using System;
using System.Security;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            KwadratowkaProxy proxy = new KwadratowkaProxy();
            Console.WriteLine("x^2 + 2x + 3 = 0 dla x=4");
            Console.WriteLine(proxy.Rozwiaz(1, 2, 3, 4));
            Console.WriteLine(proxy.Rozwiaz(1, 2, 3, 4));
            Console.WriteLine("------------------------\n2x^2 + 3x + 4 = 0 dla x=5");
            Console.WriteLine(proxy.Rozwiaz(2, 3, 4, 5));
            Console.WriteLine(proxy.Rozwiaz(2, 3, 4, 5));
        }
    }
}