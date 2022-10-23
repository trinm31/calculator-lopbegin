using System;

namespace Calculator_Lopbegin
{
    class Program
    {
        static void Main(string[] args)
        {
            var isRun = true;
            do
            {
                // 1. welcome
                Welcome();
                // 2. Provide options to select
                SelectOptionToCalculate();
                // 3. Ask User to continue
                isRun = AskToContinue(isRun);
            } while (isRun);
        }

        private static bool AskToContinue(bool isRun)
        {
            Console.WriteLine("Do you wanna continue? y/n");
            var input = Console.ReadLine();
            if (input == null || input.ToLower().Trim() == "n")
            {
                return false;
            }
            
            Console.Clear();
            return isRun;
        }

        static void Welcome()
        {
            Console.WriteLine("Welcome to our calculator");
            Console.WriteLine("--------------------------");
        }

        static void SelectOptionToCalculate()
        {
            Console.WriteLine("Please select option that you wanna to calculate");
            Console.WriteLine("Input 1 to select basic calculation (+/-/x/:/checkPrimeNumber)");
            Console.WriteLine("Input 2 to select equation calculate with degree (1/2/3)");
            Console.WriteLine("Input 3 to select find UCLN and BCNN");
            
            var input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    var basicCalculateGroup = new BasicCalculateGroup();
                    basicCalculateGroup.SelectOptionToCalculate();
                    break;
                case 2:
                    var equationGroup = new EquationGroup();
                    equationGroup.SelectOptionToCalculate();
                    break;
                case 3:
                    var uCLNandBNCN = new UCLNAndBCNN();
                    uCLNandBNCN.SelectOptionToCalculate();
                    break;
                default:
                    Console.WriteLine("Invalid input - please try again");
                    break;
            }
        }
    }
}