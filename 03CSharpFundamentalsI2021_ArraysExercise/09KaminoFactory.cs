using System;
using System.Linq;

namespace _09KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());
            int[] bestDna = new int[dnaLength];
            int bestDnaIndex = 1;
            int bestSubsequenceOf1Length = 0;
            int bestStartSubsequenceIndex = 0;
            int bestDnaSum = 0;
            int dnaIndex = 0;
            string dnaString;
            while ((dnaString = Console.ReadLine()) != "Clone them!")
            {
                dnaIndex++;
                int[] dna = dnaString.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int subsequenceOf1Length = 0;
                int startSubsequenceIndex = 0;
                int currentSubsequenceOf1Length = 0;
                for (int i = 0; i < dnaLength; i++)
                {
                    if (dna[i] == 1)
                    {
                        currentSubsequenceOf1Length++;
                    }
                    else
                    {
                        currentSubsequenceOf1Length = 0;
                    }

                    if (currentSubsequenceOf1Length > subsequenceOf1Length)
                    {
                        subsequenceOf1Length = currentSubsequenceOf1Length;
                        startSubsequenceIndex = i - subsequenceOf1Length + 1;
                    }
                }

                if (subsequenceOf1Length > bestSubsequenceOf1Length)
                {
                    bestDna = dna;
                    bestDnaIndex = dnaIndex;
                    bestSubsequenceOf1Length = subsequenceOf1Length;
                    bestStartSubsequenceIndex = startSubsequenceIndex;
                    bestDnaSum = dna.Sum();
                }
                else if (subsequenceOf1Length == bestSubsequenceOf1Length)
                {
                    if (startSubsequenceIndex < bestStartSubsequenceIndex)
                    {
                        bestDna = dna;
                        bestDnaIndex = dnaIndex;
                        bestSubsequenceOf1Length = subsequenceOf1Length;
                        bestStartSubsequenceIndex = startSubsequenceIndex;
                        bestDnaSum = dna.Sum();
                    }
                    else if (startSubsequenceIndex == bestStartSubsequenceIndex)
                    {
                        if (dna.Sum() > bestDnaSum)
                        {
                            bestDna = dna;
                            bestDnaIndex = dnaIndex;
                            bestSubsequenceOf1Length = subsequenceOf1Length;
                            bestStartSubsequenceIndex = startSubsequenceIndex;
                            bestDnaSum = dna.Sum();
                        }
                    }
                }
            }
           
            Console.WriteLine($"Best DNA sample {bestDnaIndex} with sum: {bestDnaSum}.");
            Console.WriteLine(string.Join(" ", bestDna));
        }
    }
}
