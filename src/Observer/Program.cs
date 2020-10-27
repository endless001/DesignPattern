using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new ConcreteSubject()
            {
                SubjectState = "hello"
            };
            IObserver observer = new ConcreteObserver(subject,"张三");
            subject.Add(observer);
            subject.SubjectState = "天塌了";
            subject.Nofity();
        }
    }
}
