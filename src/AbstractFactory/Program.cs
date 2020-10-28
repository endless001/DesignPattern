using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlFactory = Factory.CreateInstance("sqlserver");
            var order = sqlFactory.CreateOrderInstance();
            order.Add();
        }
    }
}
