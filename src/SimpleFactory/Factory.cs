using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
   public  class Factory
    {
        public static Database CreateInstance(string dbType)
        {
            switch (dbType)
            {
                case "Mysql":
                    return new Mysql();
                case "SqlServer":
                    return new SqlServer();
                case "SqlLite":
                    return new SqlLite();
                default:
                    throw new NotImplementedException();
                
            }


        }
    }
}
