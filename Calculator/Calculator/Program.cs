using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Write("Welcome to my calculator app. ");
            Console.Write(" Please enter the first number ");
            decimal inputOne = Decimal.Parse(Console.ReadLine());
            Console.Write("Please enter the second number ");
            decimal inputTwo = Decimal.Parse(Console.ReadLine());
            //These are the options or features for the application.
            Console.WriteLine("Choose your calculator");
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divine");
            //Writing if else statement for the option that was picked.
            string whichProblem = Console.ReadLine();
            if (whichProblem == "1")
            {
                decimal result = Add(inputOne,inputTwo);
                Console.WriteLine(" {0} + {1} = {2} ", inputOne, inputTwo, result);
                return false;
            }
            else if (whichProblem == "2")
            {
                decimal result = Subtract(inputOne, inputTwo);
                Console.WriteLine(" {0} - {1} = {2} ", inputOne, inputTwo, result);
                return false;
            }
            else if (whichProblem == "3")
            {
                decimal result = Multiply(inputOne, inputTwo);
                Console.WriteLine(" {0} * {1} = {2} ", inputOne, inputTwo, result);
                return false;
            }
            else if (whichProblem == "4")
            {
                decimal result = Divide(inputOne, inputTwo);
                Console.WriteLine(" {0} / {1} = {2} ", inputOne, inputTwo, result);
                return false;
            }
            else
            {
                return true;
            }

        }

//Adding right here
        private static decimal Add(decimal a, decimal b)
        {
            return a + b;
 
        }

//Subtracting right here
        private static decimal Subtract(decimal a, decimal b)
        {
            return a - b;
        }

//Multiplying right here
        private static decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

//Dividing right here
        private static decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }


    }
}
