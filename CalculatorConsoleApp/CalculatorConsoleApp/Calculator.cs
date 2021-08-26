
//Calculator class has all the methods for program main.
//saving some methods commented out for review purpose

using System;

namespace CalculatorConsoleApp
{
    public class Calculator
    {
        public int value1, value2;
        public string operation;

        public Calculator(int val1, int val2, string op)
        {
            value1 = val1;
            value2 = val2;
            operation = op;
        }
        public int askForNumber(int val, string str)
        {
            string entry;
            bool success = false;

            Console.Write($"Enter your {str} number : ");

            while (!success)
            {
                entry = Console.ReadLine();
                success = int.TryParse(entry, out val);

                if (!success)
                {
                    Console.WriteLine($"Your entry is not a number. Enter a valid number.");
                    Console.Write($"Enter your {str} number : ");
                }
            }
            return val;
        }
        public void calculate(int val1, int val2, string op)
        {
            decimal result = 0;
            switch (op)
            {
                case "+":
                case "add":
                    result = val1 + val2;
                    break;

                case "-":
                case "subtract":
                    result = val1 - val2;
                    break;


                case "*":
                case "multiply":
                    result = val1 * val2;
                    break;

                case "/":
                case "divide":

                    result = (decimal)val1 / val2;
                    break;
            }
            Console.WriteLine($"\n{val1} {op} {val2} = {result}");
        }

        public bool doContinue(string next)
        {
            return ((next == "Y" || next == "YES") ? true : false);
        }
    }
}

//some of the methods I have tried using but unsuccessful
//saving the code to discuss and review with my mentor & instructor

/*public string calculate()
        {
            string result = "";
            switch (operation)
            {
                case "+":
                case "add":
                    result = (value1 + value2).ToString();
                    operation = "+";
                    break;
                case "-":
                case "subtract":
                    result = (value1 - value2).ToString();
                    operation = "-";
                    break;
                case "*":
                case "multiply":
                    result = (value1 * value2).ToString();
                    operation = "*";
                    break;
                case "/":
                case "divide":
                    result = $"{((decimal)value1 / value2):F4}";   //formats to four decimal values; interger division can produce decimal results
                    operation = "/";
                    break;
            }
            return result;
        }*/
/* public string oper()
         {
             string op;
             Console.Write("Enter an operator : ");
             //char op = Convert.ToChar(Console.ReadLine());
             op = Console.ReadLine();

             /*if (op == '+' || op == '-' || op == '*' || op == '/')
             if (op == "+" || op == "-" || op == "*" || op == "/")
                 return op;
             else
             {
                 Console.WriteLine($"\nInvalid operator.{op}");
                 oper();
             }
             switch (op) 
             {
                 case "+":
                 case "-":
                 case "*":
                 case "/":
                     break;

                 default:
                     oper();
                     break;
             }
             return op;
         }*/

/* public void userInput()
 {
     string entry;
     bool success = false;

     while (!success)
     {
         Console.Write("Enter your first number : ");
         entry = Console.ReadLine();
         success = int.TryParse(entry, out value1);

         if (success)
         {
             success = false;
             break;
         }
         else
             Console.WriteLine($"Your entry is not a number. Enter a valid number");
     }

     while (!success)
     { 
         Console.Write("Enter your second number : ");
         entry = Console.ReadLine();
         success = int.TryParse(entry, out value2);

         if (!success)
         {
             Console.WriteLine($"Your entry is not a number. Enter a valid number");
         }
     }

     Console.Write("Enter an arthimatic operation \n[Add(+), Subtract(-), Multiply(*) or Divide(/)] : ");
     operation = (Console.ReadLine()).ToLower();

 }*/

