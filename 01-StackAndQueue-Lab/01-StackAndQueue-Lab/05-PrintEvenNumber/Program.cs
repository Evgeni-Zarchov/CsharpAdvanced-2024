
Queue<int> numbers = new(Console.ReadLine().Split().Select(int.Parse));

while (numbers.Any())
{
    int even = numbers.Dequeue();

    if (even % 2 == 0)
    {
        Console.Write(even);
        if (numbers.Any())
        {
            Console.Write(", ");
        }
    }
}

Console.WriteLine(string.Join(", ",numbers.Where(num => num % 2 == 0)));


