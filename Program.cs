using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to Stephen's Calculator v.1\n\n\n\n\n");
                Console.Write("Hello, enter the first number:  ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\n\n");

                Console.Write("Enter the second number:  ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\n\n");

                Console.Write("Enter an operator:  ");
                string operation = Console.ReadLine();
                Console.Write("\n\n\n");


                if (operation == "-")
                {
                    Console.WriteLine($"{firstNumber} - {secondNumber} = " + (firstNumber - secondNumber));
                }
                else if (operation == "+")
                {
                    Console.WriteLine($"{firstNumber} + {secondNumber} = " + (firstNumber + secondNumber));
                }
                else if (operation == "*")
                {
                    Console.WriteLine($"{firstNumber} * {secondNumber} = " + (firstNumber * secondNumber));
                }
                else if (operation == "/")
                {
                    Console.WriteLine($"{firstNumber} / {secondNumber} = " + (firstNumber / secondNumber));
                }
                else
                {
                    WrongOperation();
                }
            }


            catch(FormatException)
            {
                Console.WriteLine("please use numbers only");
            }


        static void WrongOperation()
            {
                Console.WriteLine("Please use the following operators:");
                Console.WriteLine("- for subtraction");
                Console.WriteLine("+ for addition");
                Console.WriteLine("/ for division");
                Console.WriteLine("* for multiplication");
            }

            Console.ReadKey();
        }
    }
}
