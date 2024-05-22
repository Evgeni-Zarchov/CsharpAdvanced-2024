using System.Runtime.Intrinsics.X86;

namespace _02_AverageStudentGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentInformation = new();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string keyName = tokens[0];
                decimal valueGrade = decimal.Parse(tokens[1]);

                if (!studentInformation.ContainsKey(keyName))
                {
                    studentInformation[keyName] = new List<decimal>();
                }

                studentInformation[keyName].Add(valueGrade);
            }

            foreach ((string student, List<decimal> grades) in studentInformation)
            {
                Console.Write($"{student} -> ");

                foreach (var grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {grades.Average():f2})");
            }
        }
    }
}
