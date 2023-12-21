using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World";
            Console.WriteLine(message);

            // Print 2 numbers
            System.Console.WriteLine(15 + 17);

            // This line performs arithmetic operations (-1 + 4 * 6) and outputs the result to the console
            System.Console.WriteLine("performs arithmetic operations (-1 + 4 * 6)");
            System.Console.WriteLine(-1 + 4 * 6); // -1 + 24 = 23

            // This line performs arithmetic operations ((35 + 5) % 7) and outputs the result to the console
            System.Console.WriteLine("performs arithmetic operations ((35 + 5) % 7) and outputs the result to the console");
            System.Console.WriteLine((35 + 5) % 7); // 40 % 7 = 5 (remainder of 40 divided by 7)

            // This line performs arithmetic operations (14 + (-4 * 6) / 11) and outputs the result to the console
            System.Console.WriteLine("performs arithmetic operations  (14 + (-4 * 6) / 11) and outputs the result to the console");
            System.Console.WriteLine(14 + -4 * 6 / 11); // 14 - (24 / 11) = 14 - 2 = 12

            // This line performs arithmetic operations (2 + 15 / 6 * 1 - 7 % 2) and outputs the result to the console
            System.Console.WriteLine("performs arithm(2 + 15 / 6 * 1 - 7 % 2)  and outputs the result to the console");
            System.Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2); // 2 + (15 / 6) - (7 % 2) = 2 + 2 - 1 = 4 - 1 = 3

            //swap 2 numbers
            System.Console.WriteLine("swap 2 members");
            int num1, num2, temp;
            Console.WriteLine("Input first number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("input scond number");
            num2 = int.Parse(Console.ReadLine());

            //swapping numbers
            temp = num1;
            num1 = num2;
            num2 = temp;

            // Displaying the result after swapping
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            Console.Read();

            //Average of numbers
            System.Console.WriteLine("Find average of numbers");
            double number1, number2, number3, number4;
            Console.Write("Enter the First number: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the third number: ");
            number3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            number4 = Convert.ToDouble(Console.ReadLine());
            double result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
                number1, number2, number3, number4, result);

            // program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.
            int x;

            Console.Write("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());

            // Printing the number in a specific pattern
            Console.WriteLine("{0}{0}{0}", x); // Prints the number three times in the same line
            Console.WriteLine("{0} {0}", x); // Prints the number twice with a space in between on each line
            Console.WriteLine("{0} {0}", x); // Prints the number twice with a space in between on each line
            Console.WriteLine("{0} {0}", x); // Prints the number twice with a space in between on each line
            Console.WriteLine("{0}{0}{0}", x); // Prints the number three times in the same line

            //C# program that removes a specified character from a non-empty string using the index of a character.

            Console.WriteLine("Displaying the result after removing a character at the specified index");
            Console.WriteLine(remove_char("w3resource", 1)); // Removes character at index 1
            Console.WriteLine(remove_char("w3resource", 9)); // Removes character at index 9 (if exists)
            Console.WriteLine(remove_char("w3resource", 0)); // Removes character at index 0

            //Create a new string from a given string where the first and last characters will change their positions
            Console.WriteLine("Create a new string from a given string where the first and last characters will change their positions");
            // Displaying the result of rearranging the first and last characters of a string
            Console.WriteLine(first_last("w3resource")); // Rearranges the first and last characters of the string
            Console.WriteLine(first_last("Python")); // Rearranges the first and last characters of the string
            Console.WriteLine(first_last("x")); // Returns the same character for a single-character string

            //Compute the sum of two given integers, if two values are equal then return the triple of their sum
            Console.WriteLine("Compute the sum of two given integers, if two values are equal then return the triple of their sum");
            // Displaying the result of the SumTriple method with different integer arguments
            Console.WriteLine(SumTriple(2, 2));   // Test case 1: Equal integers
            Console.WriteLine(SumTriple(12, 10)); // Test case 2: Different integers
            Console.WriteLine(SumTriple(-5, 2));  // Test case 3: Different integers with negative value     

        }

        // Function to remove a character at the specified index
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1); // Using Remove method to eliminate the character at index n
        }

        public static string first_last(string ustr)
        {
            // Using the ternary operator to rearrange characters based on the length of the string
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1)
                : ustr; // Returns the same character for a single-character string
        }

        // Method to calculate the sum of two integers; if they are equal, the sum is tripled
        public static int SumTriple(int a, int b)
        {
            // Using a ternary conditional operator to check if integers 'a' and 'b' are equal
            return a == b ? (a + b) * 3 : a + b; // If 'a' equals 'b', return the triple sum of 'a' and 'b', otherwise return their sum
        }

    }
    
}
