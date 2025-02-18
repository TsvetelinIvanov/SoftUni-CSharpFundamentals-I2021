using System;
using System.Linq;

namespace _10LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugIndices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];
            foreach (int ladybugIndex in ladybugIndices)
            {
                if (ladybugIndex >= 0 && ladybugIndex < fieldSize)
                {
                    field[ladybugIndex] = 1;
                }
            }

            string commandString;
            while ((commandString = Console.ReadLine()) != "end")
            {
                string[] commandArray = commandString.Split();
                int index = int.Parse(commandArray[0]);
                string direction = commandArray[1];
                int distance = int.Parse(commandArray[2]);
                if (index >= 0 && index < fieldSize && field[index] == 1)
                {
                    field[index] = 0;
                    switch (direction)
                    {
                        case "right":
                            index += distance;
                            break;
                        case "left":
                            index -= distance;
                            break;
                    }

                    while (index >= 0 && index < fieldSize && field[index] == 1)
                    {
                        switch (direction)
                        {
                            case "right":
                                index += distance;
                                break;
                            case "left":
                                index -= distance;
                                break;
                        }
                    }

                    if (index >= 0 && index < fieldSize)
                    {
                        field[index] = 1;
                    }
                }                
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
