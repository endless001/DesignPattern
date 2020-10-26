using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class FileLog : AbstractLog
    {
        public override void Write(string msg)
        {
            Console.WriteLine($"记录到File:{msg}");
        }
    }
}
