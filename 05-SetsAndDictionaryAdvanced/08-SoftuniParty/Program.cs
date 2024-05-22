namespace _08_SoftuniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();

            HashSet<string> regularGuests = new HashSet<string>();

            string command = Console.ReadLine();

            while (command != "PARTY")
            {

                if (char.IsDigit(command[0]))
                {
                    vipGuests.Add(command);
                }
                else
                {
                    regularGuests.Add(command);
                }


                command = Console.ReadLine();
            }

            while (command != "END")
            {
                if (char.IsDigit(command[0]))
                {
                    vipGuests.Remove(command);
                }
                else
                {
                    regularGuests.Remove(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);

            foreach (string guests in vipGuests)
            {
                Console.WriteLine(guests);
            }

            foreach (string guests in regularGuests)
            {
                Console.WriteLine(guests);
            }
        }
    }
}
