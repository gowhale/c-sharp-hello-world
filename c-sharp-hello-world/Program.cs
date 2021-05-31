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
