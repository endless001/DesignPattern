using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Singleton
{
    public class Drive
    {
        static Drive instance = null;
        static object lockObj = new object();
        private Drive()
        {
            Thread.Sleep(2000);
        }
        public static Drive GetInstance()
        {
            if (instance==null)
            {
                lock (lockObj)
                {
                    //双检锁 避免多线程下出现多个实例
                    if (instance == null)
                    {
                        Console.WriteLine("线程{0}： 准备new", Thread.CurrentThread.ManagedThreadId);
                        instance = new Drive();
                    }
                    else
                    {
                        Console.WriteLine("线程{0}： 当前instance有数据", Thread.CurrentThread.ManagedThreadId);
                    }
                }

            }
            return instance;
        }
        public static void Show()
        {
            Console.WriteLine("执行当前时间:{0}", DateTime.Now);
        }
    }
}
