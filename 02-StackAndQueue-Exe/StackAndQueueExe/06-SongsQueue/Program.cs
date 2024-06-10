

string[] input = Console.ReadLine().Split(", ");
Queue<string> songs = new(input);

while (true)
{
    string[] command = Console.ReadLine().Split();

    if (command[0] == "Play")
    {
        songs.Dequeue();

        if (songs.Count == 0)
        {
            Console.WriteLine("No more songs!");
            break;
        }



    }
    else if (command[0] == "Add")
    {
        string song = string.Join(" ", command.Skip(1));

        if (songs.Contains(song))
        {
            Console.WriteLine($"{song} is already contained!");
        }
        else
        {
            songs.Enqueue(song);
        }
    }
    else if (command[0] == "Show")
    {
        Console.WriteLine(string.Join(", ", songs));
    }
}
