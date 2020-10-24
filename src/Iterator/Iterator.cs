using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
   public interface Iterator
    {  
      
        int Current { get; }
        bool MoveNext();
    }
}
