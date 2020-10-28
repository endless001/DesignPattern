using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SqlServerUser : IUser
    {
        public void Add()
        {
            Console.WriteLine("SqlServer Add");
        }

        public void Remove()
        {
            Console.WriteLine("SqlServer Remove");
        }
    }
}
