using System;
using System.Text;

namespace _4.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToEncrypt = Console.ReadLine();
            StringBuilder encryptedText = new StringBuilder();

            for (int i = 0; i < textToEncrypt.Length; i++)
            {
                char currentLetter = textToEncrypt[i];
                int encryptedVal = currentLetter + 3;
                encryptedText.Append((char)encryptedVal);
            }

            Console.WriteLine(encryptedText);
        }
    }
}
