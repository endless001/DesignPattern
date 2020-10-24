using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class Mysql : Database
    {
        public override void Add()
        {
            Console.WriteLine($"{typeof(Mysql)}Add");
        }

        public override void Remove()
        {
            Console.WriteLine($"{typeof(Mysql)}Remove");
        }
    }
}
