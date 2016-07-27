using System;

namespace MyTestScores
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var scores = new int[8];
            int x;
            string inputString;
            const string FORMAT = "{0, 9}";

            for (var i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("Enter your score on test {0}", i + 1);
                inputString = Console.ReadLine();
                scores[i] = Convert.ToInt32(inputString);
            }

            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("Scores in original order:");
            for (var i = 0; i < scores.Length; i++)
            {
                Console.Write(FORMAT, scores[i]);
            }

            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("Scores in sorted order:");
            Array.Sort(scores);
            for (var i = 0; i < scores.Length; i++)
            {
                Console.Write(FORMAT, scores[i]);
            }

            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("Scores in reverse order:");
            Array.Reverse(scores);
            for (var i = 0; i < scores.Length; i++)
            {
                Console.Write(FORMAT, scores[i]);
            }
            Console.ReadKey();
        }
    }
}