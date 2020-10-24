using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregation aggregation = new Aggregation();
            aggregation.Add(1);
            aggregation.Add(2);
            aggregation.Add(3);

            var enumerator = aggregation.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
