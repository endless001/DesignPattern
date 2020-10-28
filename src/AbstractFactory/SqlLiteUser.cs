using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SqlLiteUser : IUser
    {
        public void Add()
        {
            Console.WriteLine($"SqlLite User Add");
        }

        public void Remove()
        {
            Console.WriteLine($"SqlLite User Remove");
        }
    }
}
