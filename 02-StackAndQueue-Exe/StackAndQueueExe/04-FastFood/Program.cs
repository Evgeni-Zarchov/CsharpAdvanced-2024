

int foodQuantity = int.Parse(Console.ReadLine());


Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

Console.WriteLine(orders.Max());

while (foodQuantity > 0 && orders.Count > 0)
{
    if (foodQuantity - orders.Peek() >= 0)
    {
        foodQuantity -= orders.Dequeue();
    }
    else
    {
        break;
    }
}

if (orders.Count == 0)
{
    Console.WriteLine($"Orders complete");
}
else
{
    Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
}
