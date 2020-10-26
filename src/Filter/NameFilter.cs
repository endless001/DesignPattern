using System;
using System.Collections.Generic;
using System.Text;

namespace Filter
{
    public class NameFilter : IFilter<Person>
    {
        public List<Person> Filter(List<Person> list)
        {
            return list.FindAll(i => i.Name.StartsWith("m"));
        }
    }
}
