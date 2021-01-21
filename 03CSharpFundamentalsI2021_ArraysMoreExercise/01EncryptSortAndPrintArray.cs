using System;
using System.Linq;

namespace _01EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int stringsCount = int.Parse(Console.ReadLine());
            int[] stringNumbers = new int[stringsCount];
            for (int i = 0; i < stringsCount; i++)
            {
                string inputString = Console.ReadLine();
                int inputStringLength = inputString.Length;
                int stringNumber = 0;
                for (int j = 0; j < inputStringLength; j++)
                {
                    if (vowels.Contains(inputString[j]))
                    {
                        stringNumber += inputString[j] * inputStringLength;
                    }
                    else
                    {
                        stringNumber += inputString[j] / inputStringLength;
                    }
                }

                stringNumbers[i] = stringNumber;
            }

            Array.Sort(stringNumbers);
            Console.WriteLine(string.Join(Environment.NewLine, stringNumbers));
        }
    }
}
