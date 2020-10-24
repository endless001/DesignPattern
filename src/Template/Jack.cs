using System;
using System.Collections.Generic;
using System.Text;

namespace Template
{
   public class Jack:Exam
    {
        public override string Name
        {
            get
            {
               return "Jack";
            }
        }
        public override string Answer()
        {
            return "对";   
        }
    }
}
