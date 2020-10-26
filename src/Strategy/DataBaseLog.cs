using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class DataBaseLog : AbstractLog
    {
        public override void Write(string msg)
        {
            Console.WriteLine($"记录到DataBase:{msg}");
        }
    }
}
