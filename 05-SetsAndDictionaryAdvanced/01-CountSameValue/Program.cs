namespace _01_CountSameValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            Dictionary<double, int> occurrences = new Dictionary<double, int>();

            foreach (double number in numbers)
            {
                if (!occurrences.ContainsKey(number))
                {
                    occurrences.Add(number, 0);
                }

                occurrences[number]++;
            }

            foreach (KeyValuePair<double, int> count in occurrences)
            {
                Console.WriteLine($"{count.Key} - {count.Value} times");
            }
        }
    }
}
