using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SqlLiteOrder : IOrder
    {
        public void Add()
        {
            Console.WriteLine("SqlLite Add");
        }

        public void Remove()
        {
            Console.WriteLine("SqlLite Remove");
        }
    }
}
