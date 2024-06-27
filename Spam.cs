using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseCodes
{
    class Program
    {
        static public void Main(String[] args)
        {
            Console.WriteLine("Please enter a one liner string");
            string str = Console.ReadLine();
            if (str == null || str.Length == 0)
                Console.WriteLine("Please enter a one liner string");
            else
                getCount(str);
        }

        public static void getCount(string inputString)
        {
            decimal upper = 0, lower = 0, symbols = 0, whiteSpace = 0;
            decimal totalCountOfCharacters = inputString.Length;

            foreach (char ch in inputString.ToCharArray())
            {
                if (char.IsUpper(ch)) upper++;
                else if (char.IsLower(ch)) lower++;
                else if (ch == '_') whiteSpace++;
                else symbols++;
            }

            decimal upperCaseCountRatio = upper / totalCountOfCharacters;
            decimal lowerCaseCountRatio = lower / totalCountOfCharacters; ;
            decimal whitespaceCountRatio = whiteSpace / totalCountOfCharacters; ;
            decimal symbolsCountRatio = symbols / totalCountOfCharacters; ;

            Console.WriteLine(Math.Round(whitespaceCountRatio, 6));
            Console.WriteLine(Math.Round(upperCaseCountRatio, 6));
            Console.WriteLine(Math.Round(lowerCaseCountRatio, 6));
            Console.WriteLine(Math.Round(symbolsCountRatio, 6));

        }
    }
}
