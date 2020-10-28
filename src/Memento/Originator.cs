using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Originator
    {
        public string State { get; set; }

        public string State2 { get; set; }


        public Memento CreateMemento()
        {
            return new Memento() { State = this.State };
        }
        public void RecoveryMemento(Memento memento)
        {
            this.State = memento.State;
        }
    }
}
