using System;
using System.Collections.Generic;
using System.Text;

namespace Template
{
    public class King:Exam
    {
        public override string Name { get => "King"; }

        public override string Answer()
        {
            return "错";
        }
    }
}
