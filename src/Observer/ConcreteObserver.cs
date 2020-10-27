using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class ConcreteObserver : IObserver
    {
        ISubject subject = null;

        string name = string.Empty;

        public ConcreteObserver(ISubject subject,string name)
        {
            this.subject = subject;
            this.name = name;
        }
        public void Modify()
        {
            Console.WriteLine($"{subject.SubjectState},{name}做出了反应");
        }
    }
}
