using System.Collections.Generic;

namespace Observer
{
    public class ConcreteSubject : Subject
    {
        private List<Observer> _observers;
        private string _subjectState;

        public ConcreteSubject(string defaultState = "")
        {
            _observers = new List<Observer>();
            _subjectState = defaultState;
        }

        public void Attach(Observer o)
        {
            _observers.Add(o);
        }

        public void Detach(Observer o)
        {
            _observers.Remove(o);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        public string GetState()
        {
            return _subjectState;
        }

        public void SetState(string newState)
        {
            _subjectState = newState;
            Notify();
        }
    }
}