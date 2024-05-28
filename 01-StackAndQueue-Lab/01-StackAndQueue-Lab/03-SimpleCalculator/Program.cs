
Stack<string> input = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse());

int number = int.Parse(input.Pop());

while (input.Any())
{
    string operation = input.Pop();

    if (operation == "+")
    {
        number += int.Parse(input.Pop());
    }
    else if (operation == "-")
    {
        number -= int.Parse(input.Pop());
    }
}

Console.WriteLine(number);
