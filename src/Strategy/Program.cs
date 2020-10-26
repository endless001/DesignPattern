using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyContext context = new StrategyContext(new FileLog());

            string msg = "成功！";
            context.Write(msg);
        }
    }
}
