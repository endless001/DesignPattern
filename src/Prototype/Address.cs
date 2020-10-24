using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    [Serializable]
   public class Address: ICloneable
    {
        public string Province { get; set; }

        public string City { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
