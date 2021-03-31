using System;

namespace _01WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string travel = Console.ReadLine();
            string travelChangeCommandLineString;
            while ((travelChangeCommandLineString = Console.ReadLine()) != "Travel")
            {
                string[] travelChangeCommandLine = travelChangeCommandLineString.Split(':');
                string travelChangeCommand = travelChangeCommandLine[0];
                switch (travelChangeCommand)
                {
                    case "Add Stop":
                        int index = int.Parse(travelChangeCommandLine[1]);                        
                        if (IsInTravel(travel, index))
                        {
                            string stop = travelChangeCommandLine[2];
                            travel = travel.Substring(0, index) + stop + travel[index..];
                        }
                        
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(travelChangeCommandLine[1]);
                        int endIndex = int.Parse(travelChangeCommandLine[2]);
                        if (IsInTravel(travel, startIndex) && IsInTravel(travel, endIndex))
                        {
                            travel = travel.Remove(startIndex, endIndex - startIndex + 1); 
                        }
                        
                        break;
                    case "Switch":
                        string oldStop = travelChangeCommandLine[1];
                        string newStop = travelChangeCommandLine[2];
                        travel = travel.Replace(oldStop, newStop);                        
                        break;
                    default:
                        throw new ArgumentException("Invalid command for change the travel!");
                }

                Console.WriteLine(travel);
            }

            Console.WriteLine("Ready for world tour! Planned stops: " + travel);
        }

        private static bool IsInTravel(string travel, int index)
        {
            return index >= 0 && index < travel.Length;
        }
    }
}