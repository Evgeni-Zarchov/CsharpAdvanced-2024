
using System.Net.Security;

Stack<int> numbers = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

string command = Console.ReadLine().ToLower();

while (command != "end")
{

    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (tokens[0] == "add")
    {
        int firstNum = int.Parse(tokens[1]);
        int secondNum = int.Parse(tokens[2]);

        numbers.Push(firstNum);
        numbers.Push(secondNum);
    }
    else if (tokens[0] == "remove")
    {
        int countNumberToRemove = int.Parse(tokens[1]);

        if (countNumberToRemove <= numbers.Count)
        {
            for (int i = 0; i < countNumberToRemove; i++)
            {
                numbers.Pop();
            }
        }

    }


    command = Console.ReadLine().ToLower();
}

Console.WriteLine($"Sum: {numbers.Sum()}");