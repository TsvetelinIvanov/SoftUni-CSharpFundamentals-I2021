using System;
using System.Linq;

namespace _11ArrayManipulator
{
    class Program
    {
        private static int[] numbers;

        static void Main(string[] args)
        {
            numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string commandLineString;
            while ((commandLineString = Console.ReadLine()) != "end")
            {
                string[] commandLine = commandLineString.Split();
                switch (commandLine[0])
                {
                    case "exchange":
                        ExchangeArray(int.Parse(commandLine[1]));
                        break;
                    case "max":
                        PrintMaxNumberIndex(commandLine[1]);
                        break;
                    case "min":
                        PrintMinNumberIndex(commandLine[1]);
                        break;
                    case "first":
                        PrintFirstNumbers(int.Parse(commandLine[1]), commandLine[2]);
                        break;
                    case "last":
                        PrintLastNumbers(int.Parse(commandLine[1]), commandLine[2]);
                        break;
                }
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }        

        private static void ExchangeArray(int index)
        {
            if (index >= 0 && index < numbers.Length)
            {
                int[] exchangedNumbers = numbers.Skip(index + 1).Concat(numbers.Take(index + 1)).ToArray();
                numbers = exchangedNumbers;
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            
            //Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        private static void PrintMaxNumberIndex(string numberType)
        {
            bool isEven = numberType == "even";
            bool isOdd = numberType == "odd";
            int maxNumberIndex = -1;
            int maxNumber = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (isEven && numbers[i] % 2 == 0 && numbers[i] >= maxNumber)
                {
                    maxNumberIndex = i;
                    maxNumber = numbers[i];
                }
                else if (isOdd && numbers[i] % 2 != 0 && numbers[i] >= maxNumber)
                {
                    maxNumberIndex = i;
                    maxNumber = numbers[i];
                }
            }

            if (maxNumber == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxNumberIndex);
            }
        }

        private static void PrintMinNumberIndex(string numberType)
        {
            bool isEven = numberType == "even";
            bool isOdd = numberType == "odd";
            int minNumberIndex = -1;
            int minNumber = 1001;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (isEven && numbers[i] % 2 == 0 && numbers[i] <= minNumber)
                {
                    minNumberIndex = i;
                    minNumber = numbers[i];
                }
                else if (isOdd && numbers[i] % 2 != 0 && numbers[i] <= minNumber)
                {
                    minNumberIndex = i;
                    minNumber = numbers[i];
                }
            }

            if (minNumber == 1001)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minNumberIndex);
            }
        }

        private static void PrintFirstNumbers(int count, string numberType)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            bool isEven = numberType == "even";
            bool isOdd = numberType == "odd";
            int realCount = 0;
            int[] firstNumbers = new int[count];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (isEven && numbers[i] % 2 == 0)
                {
                    firstNumbers[realCount] = numbers[i];
                    realCount++;
                }
                else if (isOdd && numbers[i] % 2 != 0)
                {
                    firstNumbers[realCount] = numbers[i];
                    realCount++;
                }

                if (realCount == count)
                {
                    break;
                }
            }

            if (count > realCount)
            {
                int[] realFirstNumbers = new int[realCount];
                for (int i = 0; i < realFirstNumbers.Length; i++)
                {
                    realFirstNumbers[i] = firstNumbers[i];
                }

                firstNumbers = realFirstNumbers;
            }

            Console.WriteLine("[" + string.Join(", ", firstNumbers) + "]");
        }

        private static void PrintLastNumbers(int count, string numberType)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            bool isEven = numberType == "even";
            bool isOdd = numberType == "odd";
            int realCount = 0;
            int[] lastNumbers = new int[count];
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (isEven && numbers[i] % 2 == 0)
                {
                    lastNumbers[realCount] = numbers[i];
                    realCount++;
                }
                else if (isOdd && numbers[i] % 2 != 0)
                {
                    lastNumbers[realCount] = numbers[i];
                    realCount++;
                }

                if (realCount == count)
                {
                    break;
                }
            }

            if (count > realCount)
            {
                int[] realLastNumbers = new int[realCount];
                for (int i = 0; i < realLastNumbers.Length; i++)
                {
                    realLastNumbers[i] = lastNumbers[i];
                }

                lastNumbers = realLastNumbers;
            }

            lastNumbers = lastNumbers.Reverse().ToArray();

            Console.WriteLine("[" + string.Join(", ", lastNumbers) + "]");
        }
    }
}
