using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day7
{
    public class ChatApplication
    {
        private readonly Dictionary<string, List<string>> _chatRooms = null;

        public ChatApplication()
        {
            _chatRooms = new Dictionary<string, List<string>>();
        }

        public void CreateChatRoom()
        {
            Console.WriteLine("Enter the Chat Room Name :");
            string roomName = Console.ReadLine();
            if (!_chatRooms.ContainsKey(roomName))
            {
                _chatRooms[roomName] = new List<string>();
                Console.WriteLine("Chat Room create successfully.");
            }
            else
            {
                Console.WriteLine($"Chat Room {roomName} already exist");
            }
        }

        public void JoinChatRoom()
        {
            Console.WriteLine("Enter the Chat Room Name you want to join :");
            string roomName = Console.ReadLine();
            if (_chatRooms.ContainsKey(roomName))
            {
                Console.WriteLine($"You have joined a chat room :{roomName}");
            }
            else
            {
                Console.WriteLine($"Chat room :{roomName}, doesn't exist");
            }
        }

        public void SendMessages()
        {
            Console.WriteLine("Enter the Chat Room Name you want to send a message :");
            string roomName = Console.ReadLine();
            if (_chatRooms.ContainsKey(roomName))
            {
                Console.Write("Enter your Message :");
                _chatRooms[roomName].Add(Console.ReadLine());
                // _chatRooms[roomName] = new List<string> { Console.ReadLine() };
                // DisplayChatRoomMessages();
            }
            else
            {
                Console.WriteLine($"Chat room :{roomName}, doesn't exist");
            }
        }

        public void DisplayChatRoomMessages()
        {
            Console.WriteLine("Enter the Chat Room Name:");
            string roomName = Console.ReadLine();
            if (_chatRooms.ContainsKey(roomName))
            {
                foreach (var message in _chatRooms[roomName])
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine($"Chat room :{roomName}, doesn't exist");
            }
        }

        static void Main(string[] args)
        {
            ChatApplication chat = new ChatApplication();
            do
            {
                Console.WriteLine("1. Create Chat Room\n2. Join Chat Room\n3. Send Message\n4. Display\n5. Exit ");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        chat.CreateChatRoom();
                        break;
                    case 2:
                        chat.JoinChatRoom();
                        break;
                    case 3:
                        chat.SendMessages();
                        break;
                    case 4:
                        chat.DisplayChatRoomMessages();
                        break;
                    case 5:
                        return;
                }
            } while (true);
        }
    }
}
