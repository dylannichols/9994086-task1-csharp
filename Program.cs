using System;

namespace _9994086_task1_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            
            // Tell user what to do
            string lineBreak = "-----------------------------------------------------";
            Console.WriteLine("This program converts between celsius and fahrenheit, you will be asked for a unit then asked for a temperature");
            Console.WriteLine(lineBreak);
            Console.WriteLine("\nType F to convert to Fahrenheit. Type C to convert to Celsius:");
            
            var input = "";
            
            // Get unit input
            do
            {
                input = Console.ReadLine();
                if (input != "C" && input != "F")
                {
                    Console.WriteLine("Invalid Input. Try again:");
                }

            } while (input != "C" && input != "F");

            // Get temperature input
            Console.WriteLine($"{lineBreak}\n");
            Console.WriteLine("Now input your temperature to convert:");
            var tempInput = Console.ReadLine();
            var temperature = 0.1;
            var isNumber = double.TryParse(tempInput, out temperature);
            
            Console.WriteLine($"{lineBreak}\n");
            
            // Check that the input is a number and if it is, convert it and output that
            if (!isNumber)
            {
                Console.WriteLine("\nPlease input an actual number next time");
            } else {
                if (input == "C")
                {
                    var converted = (temperature - 32) * 5 / 9;
                    Console.WriteLine($"Your temperature in Celsius comes to {converted}");
                } else
                {
                    var converted = temperature * 9 / 5 + 32;
                    Console.WriteLine($"Your temperature in Fahrenheit comes to {converted}");
                }
            }
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
