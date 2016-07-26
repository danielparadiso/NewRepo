using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter = "";
            char l;
            Console.WriteLine("Enter a vowel (or ! to quit): ");
            letter = Console.ReadLine();
            l = Convert.ToChar((letter));
            while (l != '!')
            {
                if (l == 'A' || l == 'a' || l == 'E' || l == 'e' || l == 'I' || l == 'i' || l == 'O' || l == 'o' ||
                    l == 'U' || l == 'u')
                    Console.WriteLine("OK");
                else
                    Console.WriteLine("That is not a vowel. Try again.");
                Console.WriteLine("Enter a vowel (or ! to quit): ");
                letter = Console.ReadLine();
                l = Convert.ToChar((letter));
            }
            Console.ReadLine();
        }
    }
}
