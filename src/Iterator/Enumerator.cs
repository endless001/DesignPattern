using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class Enumerator : Iterator
    {

        Aggregation aggregation = new Aggregation();
        int index = 0;
        int current = 0;

        public Enumerator(Aggregation aggregation)
        {
            this.aggregation = aggregation;
        }
        public int Current => current;



        public bool MoveNext()
        {
            if (index<aggregation.Length)
            {
                this.current = aggregation[index];
                index++;
                return true;
            }
            return false;
        }
    }
}
