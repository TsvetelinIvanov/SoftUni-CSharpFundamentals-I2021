using System;

namespace _04ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = Console.ReadLine().Split();
            int rotationsCount = int.Parse(Console.ReadLine()) % stringArray.Length;
            for (int i = 0; i < rotationsCount; i++)
            {
                string[] rotated = new string[stringArray.Length];
                rotated[stringArray.Length - 1] = stringArray[0];
                for (int j = 1; j <= stringArray.Length - 1; j++)
                {
                    rotated[j - 1] = stringArray[j];
                }

                stringArray = rotated;
            }

            Console.WriteLine(string.Join(" ", stringArray));
        }
    }
}
