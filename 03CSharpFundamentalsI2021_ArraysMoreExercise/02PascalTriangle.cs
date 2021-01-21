using System;

namespace _02PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            
            Console.WriteLine(1);
            if (rowsCount == 1)
            {               
                return;
            }

            int[] baseArray = { 1, 1 };
            Console.WriteLine(string.Join(" ", baseArray));
            if (rowsCount == 2)
            {                
                return;
            }

            for (int i = 0; i < baseArray.Length + 1; i++)
            {
                int[] currentArray = new int[baseArray.Length + 1];
                currentArray[0] = 1;
                currentArray[currentArray.Length - 1] = 1;

                for (int j = 1; j < currentArray.Length - 1; j++)
                {
                    currentArray[j] = baseArray[j - 1] + baseArray[j];
                }

                Console.WriteLine(string.Join(" ", currentArray));

                baseArray = currentArray;
                if (baseArray.Length == rowsCount)
                {
                    break;
                }
            }
        }
    }
}
