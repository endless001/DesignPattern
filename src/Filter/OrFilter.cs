using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Filter
{
    public class OrFilter : IFilter<Person>
    {

        List<IFilter<Person>> filters = new List<IFilter<Person>>();


        public OrFilter(List<IFilter<Person>> filters)
        {
            this.filters = filters;
        }


        public List<Person> Filter(List<Person> list)
        {

            var hashset = new HashSet<Person>();

            foreach (var filterItem in filters)
            {
                var persons = filterItem.Filter(list);
                foreach (var person in persons)
                {
                    hashset.Add(person);
                }
            }
            return hashset.ToList();
        }
    }
}
