using System;

namespace _3.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            int fileNameAndExtIndex = filePath.LastIndexOf('\\');

            string[] fileNameAndExt = filePath.Substring(fileNameAndExtIndex)
                .Split(new char[] {'.', '\\'} , StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"File name: {fileNameAndExt[0]}");
            Console.WriteLine($"File extension: {fileNameAndExt[1]}");
        }
    }
}
