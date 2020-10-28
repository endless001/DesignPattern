using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IFactory
    {
        IUser CreateUserInstance();

        IOrder CreateOrderInstance();
    }
}
