using System;

namespace Calculator_Lopbegin
{
    public class BasicCalculateGroup
    {
        // 1. plus
        public double Plus()
        {
            var (a, b) = Utility.GetTwoInput();
            return a + b;
        }
        // 2. minus
        public double Minus()
        {
            var (a, b) = Utility.GetTwoInput();
            
            return a - b;
        }
        // 3. multiple
        public double Multiple()
        {
            var (a, b) = Utility.GetTwoInput();
            
            return a * b;
        }
        // 4. device
        public double Device()
        {
            var (a, b) = Utility.GetTwoInput();
            
            return a / b;
        }
        // 5. check prime number - true/false
        public bool IsPrimeNumber()
        {
            var number = Utility.GetInput(1)[0];
            // 1. less than 1
            if (number <= 1) return false;
            // 2. equal 2
            if (number == 2) return true;
            // 3. ko chia het cho 2
            if (number % 2 == 0) return false;
            // 4. con lại
            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i+=2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        
        public void SelectOptionToCalculate()
        {
            Console.WriteLine("----------option----------");
            Console.WriteLine("Input 1 to calculate plus");
            Console.WriteLine("Input 2 to calculate minus");
            Console.WriteLine("Input 3 to calculate multiple");
            Console.WriteLine("Input 4 to calculate device");
            Console.WriteLine("Input 5 to check prime number");

            var input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine($"Result is: {Plus()}");
                    break;
                case 2:
                    Console.WriteLine($"Result is: {Minus()}");
                    break;
                case 3:
                    Console.WriteLine($"Result is: {Multiple()}");
                    break;
                case 4:
                    Console.WriteLine($"Result is: {Device()}");
                    break;
                case 5:
                    Console.WriteLine($"Is Prime Number: {IsPrimeNumber()}");
                    break;
                default:
                    Console.WriteLine("Invalid input - please input again");
                    break;
            }
        }
    }
}