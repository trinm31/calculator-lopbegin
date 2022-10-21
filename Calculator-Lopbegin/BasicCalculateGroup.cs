using System;

namespace Calculator_Lopbegin
{
    public class BasicCalculateGroup
    {
        // 1. plus
        public double Plus(double a, double b)
        {
            return a + b;
        }
        // 2. minus
        public double Minus(double a, double b)
        {
            return a - b;
        }
        // 3. multiple
        public double Multiple(double a, double b)
        {
            return a * b;
        }
        // 4. device
        public double Device(double a, double b)
        {
            return a / b;
        }
        // 5. check prime number - true/false
        public bool IsPrimeNumber(int number)
        {
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
    }
}