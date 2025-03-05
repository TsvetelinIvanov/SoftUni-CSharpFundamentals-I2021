using System;
using System.Text;

namespace _05MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            int multiplierDigit = int.Parse(Console.ReadLine());
            
            string productString = MultiplyNumber(numberString, multiplierDigit);
            Console.WriteLine(productString);
        }

        private static string MultiplyNumber(string numberString, int multiplierDigit)
        {
            if (multiplierDigit == 0)
            {
                return "0";
            }
            
            StringBuilder numberBuilder = new StringBuilder(numberString);
            StringBuilder productBuilder = new StringBuilder(numberString);
            while (numberBuilder[0] == '0' && numberBuilder.Length > 1)
            {
                numberBuilder.Remove(0, 1);
                productBuilder.Remove(0, 1);
            }

            int additionDigit = 0;
            for (int i = numberBuilder.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(numberBuilder[i].ToString());
                int currentProduct = currentDigit * multiplierDigit + additionDigit;
                
                int newDigit = currentProduct % 10;
                additionDigit = currentProduct / 10;
                productBuilder[i] = char.Parse(newDigit.ToString());
            }

            if (additionDigit > 0)
            {
                productBuilder.Insert(0, additionDigit);
            }            

            return productBuilder.ToString();
        }
    }
}
