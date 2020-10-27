using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class ChatRoom
    {
        public void ShowMessage(User user,string message)
        {
            Console.WriteLine($"{DateTime.Now},{user.Name}:{message}");
        }
    }
}
