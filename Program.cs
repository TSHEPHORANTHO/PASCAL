using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASCAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows for Pascal's Triangle: ");
            if (int.TryParse(Console.ReadLine(), out int numRows) && numRows >= 0)
            {
                PrintPascalsTriangle(numRows);
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }
        }

        static void PrintPascalsTriangle(int numRows)
        {
            for (int i = 0; i < numRows; i++)
            {
                int number = 1;
                for (int j = 0; j < numRows - i; j++)
                {
                    Console.Write("   "); // Add space for formatting
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(string.Format("{0,4}", number));
                    number = number * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
