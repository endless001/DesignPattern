using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine($"{typeof(SqlServer)}Add");
        }

        public override void Remove()
        {
            Console.WriteLine($"{typeof(SqlServer)}Remove");
        }
    }
}
