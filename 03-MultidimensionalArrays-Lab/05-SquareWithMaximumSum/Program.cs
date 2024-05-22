namespace _05_SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] matrixSize = Console.ReadLine().Split(", ");
            int rows = int.Parse(matrixSize[0]);
            int cols = int.Parse(matrixSize[1]);

            int[,] squareMatrix = new int[rows, cols];

            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                int[] inputRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    squareMatrix[row, col] = inputRow[col];
                }
            }

            int maxSum = int.MinValue;
            int rowSum = 0;
            int colSum = 0;

            for (int row = 0; row < squareMatrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < squareMatrix.GetLength(1) - 1; col++)
                {
                    int currentMaxSum = squareMatrix[row, col] +
                        squareMatrix[row, col + 1] +
                        squareMatrix[row + 1, col] +
                        squareMatrix[row + 1, col + 1];

                    if (currentMaxSum > maxSum)
                    {
                        maxSum = currentMaxSum;
                        rowSum = row;
                        colSum = col;
                    }
                }
            }

            Console.WriteLine($"{squareMatrix[rowSum, colSum]} {squareMatrix[rowSum, colSum + 1]}");
            Console.WriteLine($"{squareMatrix[rowSum + 1, colSum]} {squareMatrix[rowSum + 1, colSum + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}

