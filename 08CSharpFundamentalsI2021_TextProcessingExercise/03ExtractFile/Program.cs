using System;

namespace _03ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            int fileIndex = filePath.LastIndexOf('\\') + 1;
            int fileExtensionDotIndex = filePath.LastIndexOf('.');
            
            string fileName = filePath.Substring(fileIndex, fileExtensionDotIndex - fileIndex);
            string fileExtension = filePath.Substring(fileExtensionDotIndex + 1);

            Console.WriteLine("File name: " + fileName);
            Console.WriteLine("File extension: " + fileExtension);
        }
    }
}