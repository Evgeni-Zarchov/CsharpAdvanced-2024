
int n = int.Parse(Console.ReadLine());
Stack<int> numbers = new();

for (int i = 0; i < n; i++)
{
    int[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    if (command[0] == 1)
    {
        numbers.Push(command[1]);
    }
    else if (command[0] == 2 && numbers.Any())
    {
        numbers.Pop();
    }
    else if (command[0] == 3 && numbers.Any())
    {
        Console.WriteLine(numbers.Max());
    }
    else if (command[0] == 4 && numbers.Any())
    {
        Console.WriteLine(numbers.Min());
    }
}

Console.WriteLine(string.Join(", ", numbers));