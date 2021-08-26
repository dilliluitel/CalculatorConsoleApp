//main class for Calculator Console Application

using System;
using System.Text;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 0, value2 = 0;     //user entered values for arithmetic operation
            string operation = null;
            string next;

            var myCalculator = new Calculator(value1, value2, operation);

            do
            {
                value1 = myCalculator.askForNumber(value1, "first");

                value2 = myCalculator.askForNumber(value2, "second");

                Console.Write("\nEnter an arthimatic operation \n[Add(+), Subtract(-), Multiply(*) or Divide(/)] : ");
                operation = (Console.ReadLine()).ToLower();  //has logical error, reads all string as operator

                try
                {
                    myCalculator.calculate(value1, value2, operation);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Division by Zero cannot be performed.");
                }

                Console.WriteLine("\nWould you like to perform another calculation?");
                Console.Write("press \"Y\" for yes and \"N\" for no : ");

                next = (Console.ReadLine()).Trim().ToUpper();

                Console.WriteLine();                //inserting new line for white space

            }
            while (myCalculator.doContinue(next));
        }
    }
}
