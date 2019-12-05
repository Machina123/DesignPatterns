using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject cel = new ConcreteSubject();
            ConcreteSubject cel2 = new ConcreteSubject();
            Observer obs1 = new ConcreteObserver("Obserwator 1", cel);
            Observer obs2 = new ConcreteObserver("Obserwator 2", cel);
            Observer obs3 = new ConcreteObserver("Obserwator 3", cel2);
            Observer obs4 = new ConcreteObserver("Obserwator 4", cel2);
            cel.SetState("nowy stan");
            cel2.SetState("kolejny stan");
        }
    }
}