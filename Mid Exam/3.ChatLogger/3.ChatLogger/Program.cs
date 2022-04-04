using System;
using System.Collections.Generic;

namespace _3.ChatLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] rawInput = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

               

                string commandToken = rawInput[0];
                string messageToken = rawInput[1];

                if (commandToken == "Chat")
                {
                    chat.Insert(chat.Count, messageToken);
                }
                else if (commandToken == "Delete")
                {
                    chat.Remove(messageToken);
                }
                else if (commandToken == "Edit")
                {
                    string edditedMessage = rawInput[2];

                    int indexOfMessage = chat.IndexOf(messageToken);

                    if (indexOfMessage != -1)
                    {
                        chat[indexOfMessage] = edditedMessage;
                    }
                }
                else if (commandToken == "Pin")
                {
                    int indexOfMessage = chat.IndexOf(messageToken);

                    if (indexOfMessage != -1)
                    {
                        chat.Insert(chat.Count, chat[indexOfMessage]);
                        chat.RemoveAt(indexOfMessage);
                    }
                }
                else if (commandToken == "Spam")
                {
                    if (rawInput.Length > 0)
                    {
                        for (int i = 1; i < rawInput.Length; i++)
                        {
                            chat.Insert(chat.Count, rawInput[i]);
                        }
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var message in chat)
            {
                Console.WriteLine(message);
            }
        }
    }
}
