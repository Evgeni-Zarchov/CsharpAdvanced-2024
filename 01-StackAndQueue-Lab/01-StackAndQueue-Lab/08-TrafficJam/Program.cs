
Queue<string> cars = new();

int carPass = int.Parse(Console.ReadLine());
int carCounter = 0;

string command = Console.ReadLine();

while (command.ToLower() != "end")
{
    if (command.ToLower() == "green")
    {
        int currentPass = carPass;

        while (cars.Count > 0 && currentPass > 0)
        {
            Console.WriteLine($"{cars.Dequeue()} passed!");

            currentPass--;
            carCounter++;
        }
        command = Console.ReadLine();
        continue;
    }

    cars.Enqueue(command);
    command = Console.ReadLine();
}

Console.WriteLine($"{carCounter} cars passed the crossroads.");