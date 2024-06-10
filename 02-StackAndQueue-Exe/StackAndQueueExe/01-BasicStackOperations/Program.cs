
using System.Reflection.Metadata;

int[] operations = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

Stack<int> stack = new();

int elementToAdd = operations[0];
int elementToRemove = operations[1];
int elToPeek = operations[2];

for (int i = 0; i < elementToAdd; i++)
{
    stack.Push(numbers[i]);
}

while (stack.Any() && elementToRemove > 0)
{
    stack.Pop();
    elementToRemove--;
}

if (stack.Count == 0)
{
    Console.WriteLine("0");
}
else if (stack.Contains(elToPeek))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(stack.Min());
}