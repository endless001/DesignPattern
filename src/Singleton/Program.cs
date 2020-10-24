using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew(() =>
            {
                var drive = Drive.GetInstance();
            });
            Task.Factory.StartNew(() =>
            {
                var drive2 = Drive.GetInstance();
            });


            Task.Factory.StartNew(() =>
            {
                var drive2 = Drive.GetInstance();
            });

            Task.Factory.StartNew(() =>
            {
                var drive2 = Drive.GetInstance();
            });

            Task.Factory.StartNew(() =>
            {
                var drive2 = Drive.GetInstance();
            });

            Console.WriteLine("主线程当前时间:{0}", DateTime.Now);
            Drive.Show();

            Console.Read();
        }
    }
}
