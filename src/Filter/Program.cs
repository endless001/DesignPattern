using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();

            persons.Add(new Person() { Age = 15, Name = "mary", Email = "3333333@qq.com" });
            persons.Add(new Person() { Age = 25, Name = "111ary1", Email = "3333333@qq.com" });

            var filters = new List<IFilter<Person>>
            {
                 new NameFilter(),
                 new EmailFilter()
            };

            AndFilter andFilter = new AndFilter(filters.ToList());

            var list = andFilter.Filter(persons);

            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
