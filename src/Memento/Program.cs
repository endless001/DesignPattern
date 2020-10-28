using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator()
            {
                State="张三",
                State2="你好"
            };
            Console.WriteLine($"原始值:{originator.State}");
            Caretaker caretaker = new Caretaker()
            {
                Memento = originator.CreateMemento()
            };
            originator.State = "李四";
            Console.WriteLine($"修改后的值:{originator.State}");

            originator.RecoveryMemento(caretaker.Memento);

            Console.WriteLine(originator.State);
        }
    }
}
