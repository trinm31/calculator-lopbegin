using System;

namespace Calculator_Lopbegin
{
    public class UCLNAndBCNN
    {
        public double UCLN()
        {
            var (a, b) = Utility.GetTwoInput();

            return HandleUCLN(a, b);
        }
        
        private double HandleUCLN(double a , double b)
        {
            int UCLN = 1;
            
            var j = (a < b) ? a : b;

            for (int i = 0; i <= j; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    UCLN = i;
                }
            }

            return UCLN;
        }

        public double BCNN()
        {
            var (a, b) = Utility.GetTwoInput();

            var result = (a * b) / HandleUCLN(a, b);

            return result;
        }
        
        public void SelectOptionToCalculate()
        {
            Console.WriteLine("----------option----------");
            Console.WriteLine("Input 1 to find UCLN");
            Console.WriteLine("Input 2 to find BCNN");

            var input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine($"Result is: {UCLN()}");
                    break;
                case 2:
                    Console.WriteLine($"Result is: {BCNN()}");
                    break;
                default:
                    Console.WriteLine("Invalid input - please input again");
                    break;
            }
        }
    }
}