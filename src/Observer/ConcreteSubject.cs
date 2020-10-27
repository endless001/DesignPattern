using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class ConcreteSubject : ISubject
    {

        List<IObserver> observerList = new List<IObserver>();

        public ConcreteSubject()
        {

        }
        public string SubjectState { get; set; }

        public void Add(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void Nofity()
        {
            foreach (var observer in observerList)
            {
                observer.Modify();
            }
        }

        public void Remove(IObserver observer)
        {
            observerList.Add(observer);
        }
    }
}
