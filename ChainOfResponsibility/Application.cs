using System;
using System.Net.Security;

namespace ChainOfResponsibility
{
    public class Application : Handler
    {
        public Application() : base()
        {
        }
        
        public Application(Handler successor) : base(successor)
        {
        }

        public override void HandleHelp()
        {
            ShowHelp();
        }

        public override void ShowHelp()
        {
            Console.WriteLine($"{GetType()} -> Potrafię obsłużyć żądanie, wyświetlam pomoc");
        }
    }
}