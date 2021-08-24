using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                try
                {
                    Console.WriteLine("Welcome to Stephen's Calculator v.1\n\n\n\n\n");

                    //Reuqests first number from user
                    Console.Write("Hello, enter the first number:  ");
                    decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("\n\n\n");

                    //Requesting second number from user
                    Console.Write("Enter the second number:  ");
                    decimal secondNumber = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("\n\n\n");

                    //Requesting operator from user
                    Console.WriteLine("Please select an operator: + | - | * | /  ");
                    Console.Write("\n");
                    Console.Write("Selection:  ");
                    string operation = Console.ReadLine();
                    Console.Write("\n\n\n");



                    //Checks if user inputs one of the follwowing: - , + , * , /
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


                    //Lets user close/restart app if program ends or wrong input is given
                    Console.WriteLine("\n\n Do you want to exit this program? (y/n)");
                    var status = Console.ReadKey();
                    if (status.Key == ConsoleKey.Y)
                    {
                        break;
                    }
                    Console.ReadKey();
                    Console.Clear();



                }



                //If user inputs anything other than number, displays error message
                catch (FormatException)
                {
                    Console.WriteLine("please use numbers only");
                    Console.WriteLine("\n\n Do you want to exit this program? (y/n)");
                    var status = Console.ReadKey();
                    if (status.Key == ConsoleKey.Y)
                    {
                        break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

                //If user attempts to divide by zero, displays error message
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Please do not divide my zero.");
                    Console.WriteLine("\n\n Do you want to exit this program? (y/n)");
                    var status = Console.ReadKey();
                    if (status.Key == ConsoleKey.Y)
                    {
                        break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

            //Created method to print out correct operators if user inputs wrong selection
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

