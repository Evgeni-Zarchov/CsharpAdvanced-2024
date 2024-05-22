using System.Threading.Tasks.Dataflow;

namespace _06_JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            }

            string command;

            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] tokens = command.Split(" ");

                string action = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row < 0 || row >= rows || col < 0 || col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (action == "add")
                {
                    jaggedArray[row][col] += value;
                }
                else if (action == "subtract")
                {
                    jaggedArray[row][col] -= value;
                }
            }

            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}

