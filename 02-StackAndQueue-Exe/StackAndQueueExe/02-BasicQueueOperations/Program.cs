
int[] operations = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Queue<int> queue = new();

int elToEnqueue = operations[0];
int elToDequeue = operations[1];
int elToCheck = operations[2];

for (int i = 0; i < elToEnqueue; i++)
{
    queue.Enqueue(numbers[i]);
}

while (queue.Any() && elToDequeue > 0)
{
    queue.Dequeue();
    elToDequeue--;
}

if (queue.Count == 0)
{
    Console.WriteLine("0");
}
else if (queue.Contains(elToCheck))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(queue.Min());
}