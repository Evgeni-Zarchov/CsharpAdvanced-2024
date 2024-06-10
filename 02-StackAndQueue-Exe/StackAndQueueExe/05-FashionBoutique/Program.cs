

Stack<int> clothes = new(Console.ReadLine().Split().Select(int.Parse).ToArray());
int maxCapacity = int.Parse(Console.ReadLine());

int currentCapacity = 0;
int boxesCount = 1;

while (clothes.Any())
{
    int currentClothes = clothes.Pop();

    if (currentClothes + currentCapacity <= maxCapacity)
    {
        currentCapacity += currentClothes;
    }
    else
    {
        currentCapacity = currentClothes;
        boxesCount++;
    }
}

Console.WriteLine(boxesCount);