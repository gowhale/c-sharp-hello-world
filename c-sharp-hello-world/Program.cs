using System;

namespace c_sharp_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is my first repo using C#!");

            Console.WriteLine("Welcome to the text based calculator!");

            Console.WriteLine("Please enter the first number: ");

            string numberOne = Console.ReadLine();

            Console.WriteLine($"The following was entered: {numberOne}");

            double numberOneAsDouble = Convert.ToDouble(numberOne);

            Console.WriteLine("Please enter the second number: ");

            string numberTwo = Console.ReadLine();

            Console.WriteLine($"The following was entered: {numberTwo}");

            double numberTwoAsDouble = Convert.ToDouble(numberTwo);

            bool isOptionValid = false;

            while (!isOptionValid) {

                Console.WriteLine("Please enter one of the following options:");
                Console.WriteLine("     '+' for addition");
                Console.WriteLine("     '-' for subtraction");
                Console.WriteLine("     '*' for multiplication");
                Console.WriteLine("     '/' for division");

                string arithmaticSelection = Console.ReadLine();

                switch (arithmaticSelection)
                {
                    case "+":
                        Console.WriteLine("The sum of these two numbers is: ");
                        Console.WriteLine($"{numberOne} + {numberTwo} = {numberOneAsDouble + numberTwoAsDouble}");
                        isOptionValid = true; 
                        break;
                    case "-":
                        Console.WriteLine("The subtraction of these two numbers is: ");
                        Console.WriteLine($"{numberOne} - {numberTwo} = {numberOneAsDouble - numberTwoAsDouble}");
                        isOptionValid = true; 
                        break;
                    case "*":
                        Console.WriteLine("The multiplication of these two numbers is: ");
                        Console.WriteLine($"{numberOne} * {numberTwo} = {numberOneAsDouble * numberTwoAsDouble}");
                        isOptionValid = true; 
                        break;
                    case "/":

                        if (numberOne == "0" || numberTwo == "0")
                        {
                            Console.WriteLine("Divsion by 0 is not valid. Sorry! Try something else.");
                        }
                        else
                        {
                            Console.WriteLine("The division of these two numbers is: ");
                            Console.WriteLine($"{numberOne} / {numberTwo} = {numberOneAsDouble / numberTwoAsDouble}");
                            isOptionValid = true;
                        }
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("INVALID ENTRY PLEASE TRY AGAIN ");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                }

            }


            Console.WriteLine("Press enter to see all other combinations...");
            Console.ReadLine();


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("All possible combinations:");

            Console.WriteLine($"{numberOne} * {numberTwo} = {numberOneAsDouble * numberTwoAsDouble}");
            Console.WriteLine($"{numberOne} - {numberTwo} = {numberOneAsDouble - numberTwoAsDouble}");
            Console.WriteLine($"{numberOne} + {numberTwo} = {numberOneAsDouble + numberTwoAsDouble}");
            Console.WriteLine($"{numberOne} / {numberTwo} = {numberOneAsDouble / numberTwoAsDouble}");
            Console.WriteLine($"{numberOne} ^ {numberTwo} = {Math.Pow(numberOneAsDouble,numberTwoAsDouble)}");

            Console.WriteLine($"The minimum out of these two numbers {numberOne} and {numberTwo} is {Math.Min(numberOneAsDouble,numberTwoAsDouble)}");
            Console.WriteLine($"The maximum out of these two numbers {numberOne} and {numberTwo} is {Math.Max(numberOneAsDouble,numberTwoAsDouble)}");

        }
    }
}
