namespace _01_SumMatrixElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // reading the size of matrix

            string[] matrixSize = Console.ReadLine().Split(", ");

            // rows cols size
            int rows = int.Parse(matrixSize[0]);
            int cols = int.Parse(matrixSize[1]);


            // this is 2d matrix
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}

