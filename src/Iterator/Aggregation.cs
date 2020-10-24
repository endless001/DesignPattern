using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class Aggregation
    {
        List<int> list = new List<int>();

        public Enumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
        public void Add(int value)
        {
            list.Add(value);
        }

        public int this[int index] { get => list[index]; }

        public int Length { get => list.Count; }
    }
}
