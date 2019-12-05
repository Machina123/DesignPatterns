using System;

namespace Observer
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject _subject;
        private string _observerState;
        private string _observerName;

        public ConcreteObserver(string observerName, ConcreteSubject subject)
        {
            _subject = subject;
            _observerName = observerName;
            _subject.Attach(this);
        }

        public void Update()
        {
            _observerState = _subject.GetState();
            Console.WriteLine($"Zmiana stanu obserwatora {_observerName}: {_observerState}");
        }
    }
}