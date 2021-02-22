using System;
using System.Linq;

namespace _02ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string commandLineString;
            while ((commandLineString = Console.ReadLine()) != "end")
            {
                string[] commandLine = commandLineString.Split();
                string command = commandLine[0];
                switch (command)
                {
                    case "swap":
                        int firstIndex = int.Parse(commandLine[1]);
                        int secondIndex = int.Parse(commandLine[2]);
                        SwapIndices(array, firstIndex, secondIndex);
                        break;
                    case "multiply":
                        firstIndex = int.Parse(commandLine[1]);
                        secondIndex = int.Parse(commandLine[2]);
                        MultiplyElements(array, firstIndex, secondIndex);
                        break;
                    case "decrease":                        
                        DecreaseElements(array);
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", array));
        }

        private static void SwapIndices(int[] array, int firstIndex, int secondIndex)
        {
            int temporalElement = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temporalElement;
        }

        private static void MultiplyElements(int[] array, int firstIndex, int secondIndex)
        {
            array[firstIndex] *= array[secondIndex];
        }

        private static void DecreaseElements(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= 1;
            }
        }
    }
}