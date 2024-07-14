using System.Text.RegularExpressions;

namespace Regular_Expression__LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the file path: ");
            //string filePath = Console.ReadLine();
            //if (File.Exists(filePath))
            //{
            //    string fileContent = File.ReadAllText(filePath);
            //    Regex regex = new Regex(@"\b\d+[.,]\d+\b");
            //    MatchCollection matches = regex.Matches(fileContent);
            //    Console.WriteLine("Fractional numbers found:");
            //    foreach (Match match in matches)
            //    {
            //        Console.WriteLine(match.Value);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("File not found.");
            //}

            //TASK2

            Console.Write("Enter the file path: ");
            string filePath = Console.ReadLine();
            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                Regex regex = new Regex(@"\b\d+\b");
                MatchCollection matches = regex.Matches(fileContent);
                int[] integers = new int[matches.Count];
                int index = 0;
                foreach (Match match in matches)
                {
                    int integer;
                    if (int.TryParse(match.Value, out integer))
                    {
                        integers[index++] = integer;
                    }
                }
                Console.WriteLine("Integers found:");
                foreach (int integer in integers)
                {
                    Console.WriteLine(integer);
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }

            //task3

            int[] sequence = { 3, -1, 4, 2, -5, 1, 6, -2, 8, 0 };
            var positiveNumbers = sequence
                .Where(x => x > 0)
                .OrderBy(x => x);
            Console.WriteLine("Positive numbers in ascending order:");
            foreach (var number in positiveNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
