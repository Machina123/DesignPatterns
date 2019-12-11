using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckboxComponent ch1 = new CheckboxComponent("1", "Cwiczenia zaliczone");
            CheckboxComponent ch2 = new CheckboxComponent("2", "Wyklad (egzamin) zaliczony");
            CheckboxComponent ch3 = new CheckboxComponent("3", "Przemdiot zaliczony (wygrany konkurs)");
            
            Mediator dialogMediator = new DialogMediator(ch1, ch2, ch3);
            
            ch1.SetMediator(dialogMediator);
            ch2.SetMediator(dialogMediator);
            ch3.SetMediator(dialogMediator);
            
            while(true)
            {
                Console.Clear();
                Console.WriteLine($"1. {ch1}");
                Console.WriteLine($"2. {ch2}");
                Console.WriteLine($"3. {ch3}");
                Console.WriteLine($"4. Wyjscie z programu");
                Console.Write("Opcja? [1/2/3/4] ");
                string input = Console.ReadLine();
                if(input == "1") ch1.Check();
                else if (input == "2") ch2.Check();
                else if (input == "3") ch3.Check();
                else if (input == "4") break;
            } 
        }
    }
}