using System;

namespace Template
{

    public abstract class Exam 
    {
     
        public virtual string Name { get; set; }

        public void Questions()
        {
            Console.WriteLine($"考生姓名:{Name},答案:{Answer()}");
        }

        public virtual string Answer()
        {
            return string.Empty;

        }
    }

}