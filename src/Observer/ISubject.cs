using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface ISubject
    {
        string SubjectState { get; set; }
        void Add(IObserver observer);
        void Remove(IObserver observer);
        void Nofity();
    }
}
