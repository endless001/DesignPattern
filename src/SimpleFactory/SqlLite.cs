using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class SqlLite : Database
    {
        public override void Add()
        {
            Console.WriteLine($"{typeof(SqlLite)}Add");
        }

        public override void Remove()
        {
            Console.WriteLine($"{typeof(SqlLite)}Remove");
        }
    }
}
