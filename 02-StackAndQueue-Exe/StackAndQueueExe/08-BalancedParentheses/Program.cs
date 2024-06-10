
string input = Console.ReadLine();

Stack<char> stack = new();

bool isBalanced = true;

foreach (var item in input)
{
    if (item is '(' or '[' or '{')
    {
        stack.Push(item);

        continue;
    }

    bool can = stack.TryPeek(out char currentChar);

    if (can && ((currentChar == '(' && item == ')')
        || (currentChar == '[' && item == ']') 
        || (currentChar == '{' && item == '}')))
    {
        stack.Pop();
    }
    else
    {
        isBalanced = false;
        break;
    }
}

if (isBalanced)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
