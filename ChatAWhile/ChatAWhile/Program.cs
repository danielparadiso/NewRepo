using System;

namespace ChatAWhile
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] areaCode = {"262", "414", "608", "715", "815", "920"};
            double[] charge = {0.07, 0.10, 0.05, 0.16, 0.24, 0.14};
            var numOfMins = 0.0;
            var totalCharge = 0.0;
            var inputString = "";
            var inputMins = "";
            var isValidCode = false;
            int x;

            Console.WriteLine("Welcome to Chat-A-While");
            Console.WriteLine("Please enter an area code (or 999 to quit): ");
            inputString = Console.ReadLine();
            x = 0;
            while (inputString != "999")
            {
                
                while (x < areaCode.Length && inputString != areaCode[x])
                    x++;
                if (x != areaCode.Length)
                {
                    isValidCode = true;

                    Console.WriteLine("Now enter the number of minutes to find out how much the call will cost: ");
                    inputMins = Console.ReadLine();
                    numOfMins = Convert.ToDouble(inputMins);
                    totalCharge = numOfMins * charge[x];
                }
                else
                    Console.WriteLine("Sorry, area code {0} is not in our area.", inputString);

                if (isValidCode)
                    Console.WriteLine("The total charge for calling area code {0} for {1} minutes is {2}", inputString,
                        numOfMins,
                        totalCharge.ToString("C"));
                

                isValidCode = false;
                x = 0;
                Console.WriteLine("Please enter an area code (or 999 to quit): ");
                inputString = Console.ReadLine();
           
            }
            Console.WriteLine("Have a nice day!");
            Console.ReadKey();
        }
    }
}