
Queue<string> names = new();

string command = Console.ReadLine();

while (command != "End")
{

    if (command != "Paid")
    {
        names.Enqueue(command);
    }
    else
    {
        while (names.Any())
        {
            Console.WriteLine($"{names.Dequeue()}");
        }
    }

    command = Console.ReadLine();
}

Console.WriteLine($"{names.Count} people remaining.");

