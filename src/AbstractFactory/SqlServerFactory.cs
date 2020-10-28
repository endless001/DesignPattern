using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SqlServerFactory : IFactory
    {
        public IOrder CreateOrderInstance()
        {
            return new SqlServerOrder();
        }

        public IUser CreateUserInstance()
        {
            return new SqlServerUser();
        }
    }
}
