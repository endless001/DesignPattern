using System;
using System.Collections.Generic;
using System.Text;

namespace Filter
{
    public class AndFilter : IFilter<Person>
    {

        List<IFilter<Person>> filters = new List<IFilter<Person>>();


        public AndFilter(List<IFilter<Person>> filters)
        {
            this.filters = filters;

        }

        public List<Person> Filter(List<Person> list)
        {
            var persons = new List<Person>(list);
            foreach (var item in filters)
            {
                persons = item.Filter(persons);
            }
            return persons;
        }
    }
}
