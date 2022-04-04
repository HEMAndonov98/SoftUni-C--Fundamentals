using System;
using System.Text;

namespace _5.DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            var encryptedMessage = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                int currLetter;
                int encryption;
                char letter = char.Parse(Console.ReadLine());

                if (char.IsUpper(letter))
                {
                    currLetter = letter - 65;
                    encryption = 65 + (currLetter + key);
                    encryptedMessage.Append((char)encryption);

                }
                else if(char.IsLower(letter))
                {
                    currLetter = letter - 97;
                    encryption = 97 + (currLetter + key);
                    encryptedMessage.Append((char)encryption);

                }
            }

            Console.WriteLine(encryptedMessage);

        }
    }
}
