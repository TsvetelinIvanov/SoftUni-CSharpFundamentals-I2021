using System;

namespace _01Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string ageType = "The age should be a positive number!";
            if (age >= 0 && age <= 2)
            {
                ageType = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                ageType = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                ageType = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                ageType = "adult";
            }
            else if (age >= 66)
            {
                ageType = "elder";
            }

            Console.WriteLine(ageType);
        }
    }
}
