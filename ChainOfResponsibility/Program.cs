using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Application anApplication = new Application();
            Dialog aSaveDialog = new Dialog();
            Dialog aPrintDialog = new Dialog();
            Button aPrintButton = new Button();
            Button anOkButton = new Button();
            
            anOkButton.SetSuccessor(aPrintDialog);
            aPrintButton.SetSuccessor(aPrintDialog);
            aPrintDialog.SetSuccessor(anApplication);
            aSaveDialog.SetSuccessor(anApplication);

            anOkButton.HandleHelp();
            Console.WriteLine("------------");
            aPrintButton.HandleHelp();
            Console.WriteLine("------------");
            aSaveDialog.HandleHelp();
        }
    }
}