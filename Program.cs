using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, enter the first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter an operator: ");
                string op = Console.ReadLine();

                Console.WriteLine("Enter the second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                if (op == "-")
                {
                    Console.WriteLine($"{firstNumber} - {secondNumber} = " + (firstNumber - secondNumber));
                }
                else if (op == "+")
                {
                    Console.WriteLine($"{firstNumber} + {secondNumber} = " + (firstNumber + secondNumber));
                }
                else if (op == "*")
                {
                    Console.WriteLine($"{firstNumber} * {secondNumber} = " + (firstNumber * secondNumber));
                }
                else if (op == "/")
                {
                    Console.WriteLine($"{firstNumber} / {secondNumber} = " + (firstNumber / secondNumber));
                }
                else
                {
                    Console.WriteLine("Please use the following operators:");
                    Console.WriteLine("- for subtraction");
                    Console.WriteLine("+ for addition");
                    Console.WriteLine("/ for division");
                    Console.WriteLine("* for multiplication");
                }
            }


            catch(FormatException)
            {
                Console.WriteLine("please use numbers only");
            }


            Console.ReadKey();
        }
    }
}
