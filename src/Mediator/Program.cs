using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            User robert = new User() { Name= "Robert" };
            robert.SendMessage("Hi");
        }
    }
}
