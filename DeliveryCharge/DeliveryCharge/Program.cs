﻿using System;

namespace DeliveryCharge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] zipCode = {"12321", "23432", "34543", "45654", "56765", "67876", "78987", "89098", "90109", "01210"};
            double[] deliverCharge = {1.00, 2.50, 3.75, 4.25, 5.50, 6.25, 7.30, 8.90, 9.45, 10.25};
            var inputString = "";
            double charge = 0;
            var isValidZip = false;
            int x;
            Console.WriteLine("Enter a zip code (or enter 999 to quit): ");
            inputString = Console.ReadLine();
            x = 0;
            while (inputString != "999")
            {
                while (x < zipCode.Length && inputString != zipCode[x])
                    ++x;
                if (x != zipCode.Length)
                {
                    isValidZip = true;
                    charge = deliverCharge[x];
                }
                if (isValidZip)
                    Console.WriteLine("The delivery charge for {0} is {1}.", zipCode[x], charge.ToString("C"));
                else
                    Console.WriteLine("We do not deliver to {0}.", inputString);

                isValidZip = false;
                x = 0;
                Console.WriteLine("Enter a zip code (or enter 999 to quit): ");
                inputString = Console.ReadLine();

            }
            Console.WriteLine("Have a nice day!");
            Console.ReadKey();
        }
    }
}