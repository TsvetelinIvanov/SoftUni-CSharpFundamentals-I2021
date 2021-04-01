using System;
using System.Text.RegularExpressions;

namespace _02FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex barcodeRegex = new Regex(@"^@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+$");
            int barcodesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < barcodesCount; i++)
            {
                string barcodeRaw = Console.ReadLine();
                Match barcodeMatch = barcodeRegex.Match(barcodeRaw);
                if (barcodeMatch.Success)
                {
                    string barcode = barcodeMatch.Groups[1].Value;
                    string productGroup = ExtractProductGroup(barcode);
                    Console.WriteLine(productGroup);
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }

        private static string ExtractProductGroup(string barcode)
        {
            string productGroup = string.Empty;
            for (int i = 0; i < barcode.Length; i++)
            {
                if (Char.IsDigit(barcode[i]))
                {
                    productGroup += barcode[i];
                }
            }

            if (productGroup == string.Empty)
            {
                return "Product group: 00";
            }
            else
            {
                return "Product group: " + productGroup;
            }
        }
    }
}