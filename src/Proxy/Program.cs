using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image = new ProxyImage("test_10mb.jpg");
            image.Display();
            image.Display();
            Console.Read();
        }
    }
}
