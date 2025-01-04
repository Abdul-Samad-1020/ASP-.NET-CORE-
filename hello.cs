using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, C#!");

            // Variables
            int num1 = 5;
            int num2 = 10;
            int sum = num1 + num2;
            Console.WriteLine($"Sum of {num1} and {num2} is: {sum}");

            // Data Types
            int integerNumber = 10;
            double decimalNumber = 3.14;
            char character = 'A';
            bool isTrue = true;
            string greeting = "Hello, World!";

            Console.WriteLine($"Integer: {integerNumber}");
            Console.WriteLine($"Decimal: {decimalNumber}");
            Console.WriteLine($"Character: {character}");
            Console.WriteLine($"Boolean: {isTrue}");
            Console.WriteLine($"String: {greeting}");

            // Arrays
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"First number in the array: {numbers[0]}");

            // Loops
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number at index {i}: {numbers[i]}");
            }

            // Conditionals
            if (sum > 15)
            {
                Console.WriteLine("Sum is greater than 15");
            }
            else
            {
                Console.WriteLine("Sum is not greater than 15");
            }

            // Methods
            int result = AddNumbers(num1, num2);
            Console.WriteLine($"Result of AddNumbers method: {result}");

            // Classes
            Car myCar = new Car("Toyota", "Corolla", 2022);
            Console.WriteLine($"My car is a {myCar.Make} {myCar.Model} from {myCar.Year}");
        }

        // Method declaration
        static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        // Class declaration
        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            public Car(string make, string model, int year)
            {
                Make = make;
                Model = model;
                Year = year;
            }
        }
    }
}