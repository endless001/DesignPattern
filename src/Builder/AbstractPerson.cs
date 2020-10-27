using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class AbstractPerson
    {
        public abstract void CreateHead();
        public abstract void CreateBody();
        public abstract void CreateLeg();
        public abstract void CreateHand();


    }
}
