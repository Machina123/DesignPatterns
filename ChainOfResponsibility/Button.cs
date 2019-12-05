using System;

namespace ChainOfResponsibility
{
    public class Button : Handler
    {
        public Button() : base()
        {
        }

        public Button(Handler successor) : base(successor)
        {
        }

        public override void HandleHelp()
        {
            Console.WriteLine($"{GetType()} -> Nie potrafię obsłużyć żądania, przekazuję dalej");
            _successor.HandleHelp();
        }

        public override void ShowHelp()
        {
            throw new NotImplementedException();
        }
    }
}