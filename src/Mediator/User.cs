using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class User
    {
        ChatRoom chatRoom;
        public User()
        {
            chatRoom = new ChatRoom();
        }
           
        public string Name { get; set; }

        public void SendMessage(string message)
        {
            chatRoom.ShowMessage(this, message);

        }
    }
}
