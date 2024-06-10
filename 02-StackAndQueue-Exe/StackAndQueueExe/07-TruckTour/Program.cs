
int n = int.Parse(Console.ReadLine());

Queue<(int, int)> pumps = new();

for (int i = 0; i < n; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

    int petrol = input[0];
    int km = input[1];

    pumps.Enqueue((petrol, km));
}

int index = 0;

while (true)
{
    int totalPetrol = 0;

    foreach (var pump in pumps)
    {
        totalPetrol += pump.Item1;
        int km = pump.Item2;

        totalPetrol -= km;

        if (totalPetrol < 0)
        {
            break;
        }
    }

    if (totalPetrol < 0)
    {
        index++;
        pumps.Enqueue(pumps.Dequeue());
    }
    else
    {
        break;
    }
}

Console.WriteLine(index);
