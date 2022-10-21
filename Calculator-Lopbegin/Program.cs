using System;

namespace Calculator_Lopbegin
{
    class Program
    {
        static void Main(string[] args)
        {
            EquationGroup equationGroup = new EquationGroup();
            var list = equationGroup.GetInput(2);
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}