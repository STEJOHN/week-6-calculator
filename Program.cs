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

                //Reuqesting first number from user
                Console.Write("Hello, enter the first number:  ");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n\n\n");

                //Requesting second number from user
                Console.Write("Enter the second number:  ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n\n\n");

                //Requesting operator from user
                Console.WriteLine("Please select an operator: + | - | * | /  ");
                Console.Write("\n");
                Console.Write("Selection:  ");
                string operation = Console.ReadLine();
                Console.Write("\n\n\n");

                

                //Checks if user imputted one of the follwowing: - , + , * , /
                if (operation == "-")
                {
                    Console.WriteLine($"Result: {firstNumber} - {secondNumber} = " + (firstNumber - secondNumber));
                }
                else if (operation == "+")
                {
                    Console.WriteLine($"Result: {firstNumber} + {secondNumber} = " + (firstNumber + secondNumber));
                }
                else if (operation == "*")
                {
                    Console.WriteLine($"Result: {firstNumber} * {secondNumber} = " + (firstNumber * secondNumber));
                }
                else if (operation == "/")
                {
                    Console.WriteLine($"Result: {firstNumber} / {secondNumber} = " + (firstNumber / secondNumber));
                }
                //If user inputs anything other than available operators, error is called from WrongOperation method
                else
                {
                    //Method is invoked to print operators
                    OperationList();
                }
            }

            //If user inputs anything but a number, displays error message
            catch (FormatException)
            {
                Console.WriteLine("please use numbers only");
            }
            //If user attempts to divide by zero, displays error message
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please do not divide my zero.");
            }

            //Created method to print out correct operators if user inputted wrong value
            static void OperationList()
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
