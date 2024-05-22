namespace _03_PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int rows = 0; rows < size; rows++)
            {
                int[] matrixNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int cols = 0; cols < size; cols++)
                {
                    matrix[rows, cols] = matrixNumbers[cols];
                }
            }

            int sumOfDiagonal = 0;

            for (int i = 0; i < size; i++)
            {
                sumOfDiagonal += matrix[i, i];
            }

            Console.WriteLine(sumOfDiagonal);
        }
    }
}



