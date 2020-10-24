using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    [Serializable]
   public class Person : ICloneable
    {

        public string Name { get; set; }

        public int Age { get; set; }

        public Address Address { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
