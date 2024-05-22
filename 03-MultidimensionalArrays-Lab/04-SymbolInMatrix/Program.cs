using System.Data.Common;
using System.Runtime.Serialization;

namespace _04_SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int rows = 0; rows < size; rows++)
            {
                string strings = Console.ReadLine();

                for (int cols = 0; cols < size; cols++)
                {
                    matrix[rows, cols] = strings[cols];
                }
            }

            string searchedChar = Console.ReadLine();

            for (int rows = 0; rows < size; rows++)
            {
                for (int cols = 0; cols < size; cols++)
                {
                    if (matrix[rows, cols] == searchedChar[0])
                    {
                        Console.WriteLine($"({rows}, {cols})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{searchedChar} does not occur in the matrix");
        }
    }
}
