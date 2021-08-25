using System;

namespace Calculator
{



    class Program
    {


        static void Main(string[] args)
        {


            decimal firstNumber, secondNumber, result = 0;
            string operation = "";


            while (true)
                try
                {
                    Console.WriteLine("Welcome to Stephen's Calculator v.1\n\n\n\n\n");

                    //Reuqests first number from user
                    Console.Write("Hello, enter the first number:  ");
                    firstNumber = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("\n\n\n");

                    //Requesting second number from user
                    Console.Write("Enter the second number:  ");
                    secondNumber = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("\n\n\n");

                    //Requesting operator from user
                    Console.WriteLine("Please select an operator: + | - | * | /  ");
                    Console.Write("\n");
                    Console.Write("Selection:  ");
                    operation = Console.ReadLine();
                    Console.Write("\n\n\n");



                    //Checks if user inputs one of the follwowing: - , + , * , /
                    if (operation == "-")
                    {
                        result = Subtract(firstNumber, secondNumber);
                        ResultOutput(firstNumber, secondNumber, result, operation);
                    }
                    else if (operation == "+")
                    {
                        result = Add(firstNumber, secondNumber);
                        ResultOutput(firstNumber, secondNumber, result, operation);
                    }
                    else if (operation == "*")
                    {
                        result = Multiply(firstNumber, secondNumber);
                        ResultOutput(firstNumber, secondNumber, result, operation);
                    }
                    else if (operation == "/")
                    {
                        result = Divide(firstNumber, secondNumber);
                        ResultOutput(firstNumber, secondNumber, result, operation);
                    }

                    //If user inputs anything other than available operators, error is called from WrongOperation method
                    else
                    {
                        //Method is invoked to print operators
                        OperationList();
                    }



                    //Lets user close/restart app if program ends or wrong input is given
                    Console.WriteLine("\n\nDo you want to exit this program? (y/n)");
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
                    Console.WriteLine("\n\nDo you want to exit this program? (y/n)");
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
                    Console.WriteLine("Please do not divide by zero.");
                    Console.WriteLine("\n\nDo you want to exit this program? (y/n)");
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



        //Created methods to calculate input for numbers
        public static decimal Subtract(decimal firstNumber, decimal secondNumber)
        {
            decimal result = firstNumber - secondNumber;
            return result;
        }

        public static decimal Add(decimal firstNumber, decimal secondNumber)
        {
            decimal result = firstNumber + secondNumber;
            return result;
        }

        public static decimal Divide(decimal firstNumber, decimal secondNumber)
        {
            decimal result = firstNumber / secondNumber;
            return result;
        }

        public static decimal Multiply(decimal firstNumber, decimal secondNumber)
        {
            decimal result = firstNumber * secondNumber;
            return result;
        }

        //created this method to display output of 1st/2nd number and operation 
        static void ResultOutput(decimal firstNumber, decimal secondNumber, decimal result, string operation)
        {
            Console.WriteLine("Result:  " + firstNumber + " " + operation + " " + secondNumber + " " + " = " + result);
        }


    }


}



