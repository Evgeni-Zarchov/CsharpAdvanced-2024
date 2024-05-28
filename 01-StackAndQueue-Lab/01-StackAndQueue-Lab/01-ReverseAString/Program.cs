namespace _01_ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> words = new();

            foreach (char chars in input)
            {
                words.Push(chars);
            }

            while (words.Count > 0)
            {
                Console.Write(words.Pop());
            }
        }
    }
}
