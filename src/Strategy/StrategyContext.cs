using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class StrategyContext
    {
        AbstractLog log = null;

        public StrategyContext(AbstractLog log)
        {
            this.log = log;
        }

        public  void Write(string msg) 
        {
            log.Write(msg);
        }
    }
}
