using System;

namespace _04ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int rotationsCount = int.Parse(Console.ReadLine()) % arr.Length;
            for (int i = 0; i < rotationsCount; i++)
            {
                string[] rotated = new string[arr.Length];
                rotated[arr.Length - 1] = arr[0];
                for (int j = 1; j <= arr.Length - 1; j++)
                {
                    rotated[j - 1] = arr[j];
                }

                arr = rotated;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
