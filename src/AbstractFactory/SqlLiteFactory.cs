using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SqlLiteFactory : IFactory
    {
        public IOrder CreateOrderInstance()
        {
            return new SqlLiteOrder();
        }

        public IUser CreateUserInstance()
        {
            return new SqlLiteUser();
        }
    }
}
