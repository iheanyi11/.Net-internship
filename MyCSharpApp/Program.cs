using System;


class Program
{
     static void Main(string[] args)
        {
            // Task 1: Declare and initialize variables
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;

            // Print the values of the variables
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Is Admin: {isAdmin}");
            Console.WriteLine();

           // Task 2: Determine if input number is even or odd
            Console.Write("Enter an integer: ");
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.WriteLine();

            // Task 3: Print numbers 1 to 10 using a for loop
            Console.WriteLine("Numbers from 1 to 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Task 4: Declare and initialize an integer array and calculate sum
            int[] numbers = { 2, 4, 6, 8, 10 };
            int sum = 0;

            Console.WriteLine("Array elements:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
                sum += num;
            }

            Console.WriteLine($"Sum of array elements: {sum}");
            Console.WriteLine();

            // Task 5: Call the Greet method
            Greet("Alice");

            // Prevent console from closing immediately
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // Task 5: Greet method that prints a personalized greeting
        static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        
}
