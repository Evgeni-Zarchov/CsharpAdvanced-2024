namespace _07_ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string direction = tokens[0];
                string carNumber = tokens[1];

                if (direction == "IN")
                {
                    parkingLot.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    parkingLot.Remove(carNumber);
                }


                command = Console.ReadLine();

            }


            if (parkingLot.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            Console.WriteLine(string.Join(Environment.NewLine, parkingLot));
        }
    }
}
