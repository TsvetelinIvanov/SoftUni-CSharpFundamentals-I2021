using System;

namespace _09PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal disposableMoney = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            decimal lightsaberPrice = decimal.Parse(Console.ReadLine());
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal beltPrice = decimal.Parse(Console.ReadLine());

            decimal allLightsabersPrice = lightsaberPrice * Math.Ceiling(studentsCount * 1.1m);            
            decimal allRobesPrice = robePrice * studentsCount;
            decimal allBeltsPrice = beltPrice * (studentsCount - studentsCount / 6);            

            decimal allItemsPrice = allLightsabersPrice + allRobesPrice + allBeltsPrice;                        

            if (allItemsPrice <= disposableMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {allItemsPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {allItemsPrice - disposableMoney:f2}lv more.");
            }
        }
    }
}
