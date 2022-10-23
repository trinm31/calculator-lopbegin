using System;
using System.Collections.Generic;

namespace Calculator_Lopbegin
{
    public class Utility
    {
        public static List<double> GetInput(int degree)
        {
            var inputList = new List<double>();
            for (int i = 0; i < degree; i++)
            {
                var input = "";
                Console.WriteLine($"Let's input {i+1}: ");
                input = Console.ReadLine();

                double cleanInput = 0;
                while (!double.TryParse(input, out cleanInput))
                {
                    Console.WriteLine("This is not valid input, please enter double number");
                    input = Console.ReadLine();
                }
                
                inputList.Add(cleanInput);
            }

            return inputList;
        }
        
        public static (double, double) GetTwoInput()
        {
            var inputList = Utility.GetInput(2);

            var a = inputList[0];
            var b = inputList[1];

            return (a, b);
        }
    }
}