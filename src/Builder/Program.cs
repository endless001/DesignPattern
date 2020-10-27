using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            BuidlerDirector director = new BuidlerDirector(new FatPerson());
            director.CreatePerson();
        }
    }
}
