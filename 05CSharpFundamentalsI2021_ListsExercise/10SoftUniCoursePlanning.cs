using System;
using System.Linq;
using System.Collections.Generic;

namespace _10SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lesons = Console.ReadLine().Split(", ").ToList();
            string commandLineString;
            while ((commandLineString = Console.ReadLine()) != "course start")
            {
                string[] commandLine = commandLineString.Split(':');
                string command = commandLine[0];
                string leson = commandLine[1];
                switch (command)
                {
                    case "Add":
                        if (!lesons.Contains(leson))
                        {
                            lesons.Add(leson);
                        }

                        break;
                    case "Insert":
                        int index = int.Parse(commandLine[2]);
                        if (!lesons.Contains(leson))
                        {
                            lesons.Insert(index, leson);
                        }

                        break;
                    case "Remove":
                        if (lesons.Contains(leson))
                        {
                            lesons.Remove(leson);
                        }

                        if (lesons.Contains(leson + "-Exercise"))
                        {
                            lesons.Remove(leson + "-Exercise");
                        }

                        break;
                    case "Swap":
                        string lesonToSwap = commandLine[2];
                        SwapLesons(lesons, leson, lesonToSwap);
                        break;
                    case "Exercise":
                        AddExercise(lesons, leson);
                        break;
                }
            }

            int lesonIndex = 0;
            foreach (string leson in lesons)
            {
                Console.WriteLine(++lesonIndex + "." + leson);
            }
        }

        private static void SwapLesons(List<string> lesons, string firstLeson, string secondLeson)
        {
            if (!lesons.Contains(firstLeson) || !lesons.Contains(secondLeson))
            {
                return;
            }

            int firstLesonIndex = lesons.IndexOf(firstLeson);
            int firstExerciseIndex = lesons.IndexOf(firstLeson + "-Exercise");
            int secondLesonIndex = lesons.IndexOf(secondLeson);
            int secondExerciseIndex = lesons.IndexOf(secondLeson + "-Exercise");

            //int firstLesonIndex = -1;
            //int firstExerciseIndex = -1;
            //int secondLesonIndex = -1;
            //int secondExerciseIndex = -1;
            //for (int i = 0; i < lesons.Count; i++)
            //{
            //    if (lesons[i] == firstLeson)
            //    {
            //        firstLesonIndex = i;
            //    }

            //    if (lesons[i] == firstLeson + "-Exercise")
            //    {
            //        firstExerciseIndex = i;
            //    }

            //    if (lesons[i] == secondLeson)
            //    {
            //        secondLesonIndex = i;
            //    }

            //    if (lesons[i] == secondLeson + "-Exercise")
            //    {
            //        secondExerciseIndex = i;
            //    }
            //}

            string lesonToSwap = lesons[firstLesonIndex];
            lesons[firstLesonIndex] = lesons[secondLesonIndex];
            lesons[secondLesonIndex] = lesonToSwap;

            if (firstExerciseIndex >= 0)
            {
                lesons.RemoveAt(firstExerciseIndex);
                lesons.Insert(secondLesonIndex + 1, firstLeson + "-Exercise");
            }

            if (secondExerciseIndex >= 0)
            {
                lesons.RemoveAt(secondExerciseIndex);
                lesons.Insert(firstLesonIndex + 1, secondLeson + "-Exercise");
            }
        }

        private static void AddExercise(List<string> lesons, string leson)
        {
            if (lesons.Contains(leson))
            {
                if (!lesons.Contains(leson + "-Exercise"))
                {
                    int lesonIndex = lesons.IndexOf(leson);
                    lesons.Insert(lesonIndex + 1, leson + "-Exercise");
                }
            }
            else
            {
                lesons.Add(leson);
                lesons.Add(leson + "-Exercise");
            }
        }        
    }
}
