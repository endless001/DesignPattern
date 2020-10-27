using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class BuidlerDirector
    {
        AbstractPerson person = null;
        
        public BuidlerDirector(AbstractPerson person)
        {
            this.person = person;
        }

        public void CreatePerson()
        {
            this.person.CreateHead();
            this.person.CreateBody();
            this.person.CreateHand();
            this.person.CreateLeg();
        }
    }
}
