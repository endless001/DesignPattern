using System;
using System.Collections.Generic;
using System.Text;

namespace Filter
{
    public class EmailFilter : IFilter<Person>
    {
        public List<Person> Filter(List<Person> list)
        {
            return list.FindAll(i => i.Email == "3333333@qq.com");
        }
    }
}
