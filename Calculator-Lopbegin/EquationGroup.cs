using System;
using System.Collections.Generic;

namespace Calculator_Lopbegin
{
    public class EquationGroup
    {
        // 1.phương tình bậc 1 ax + b = 0 
        public void EquationOfDegreeOne()
        {
            Console.WriteLine("Equation pattern ax+b=0");

            var inputList = Utility.GetInput(2);

            var a = inputList[0];
            var b = inputList[1];
            
            var result = -b / a;
            
            Console.WriteLine($"Result of x = {result}");
        }
        // 2.phương tình bậc 2
        public void EquationOfDegreeTwo()
        {
            Console.WriteLine("Equation pattern ax^2+bx+c=0");

            var inputList = Utility.GetInput(3);

            var a = inputList[0];
            var b = inputList[1];
            var c = inputList[2];

            double delta, x1, x2;
            if (a == 0)
            {
                x1 = -c / b;
                Console.WriteLine($"One result is {x1}");
            }
            else
            {
                delta = (b * b) - 4 * a * c;
                if (delta > 0)
                {
                    x1 = (-b / 2 * a) + (Math.Sqrt(delta) / 2 + a);
                    x2 = (-b / 2 * a) - (Math.Sqrt(delta) / 2 + a);
                    Console.WriteLine($"Equation have x1: {x1} x2: {x2}");
                }
                else if (delta == 0)
                {
                    x1 = -b / 2 * a;
                    Console.WriteLine($"Equation have x1 equal x2: {x1}");
                }
                else
                {
                    Console.WriteLine("No result");
                }
            }
        }
        
        public void SelectOptionToCalculate()
        {
            Console.WriteLine("----------option----------");
            Console.WriteLine("Input 1 to equation degree 1");
            Console.WriteLine("Input 2 to equation degree 2");

            var input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    EquationOfDegreeOne();
                    break;
                case 2:
                    EquationOfDegreeTwo();
                    break;
                default:
                    Console.WriteLine("Invalid input - please input again");
                    break;
            }
        }

        // 3.phương tình bậc 3

      
    }
}