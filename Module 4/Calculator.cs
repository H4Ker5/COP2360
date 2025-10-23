using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first number: ");
            string input1 = Console.ReadLine();

            Console.WriteLine("Please enter your second number: ");
            string input2 = Console.ReadLine();

            try
            {
                // 
                int num2 = Convert.ToInt32(input1);
                int num2 = Convert.ToInt32(input2);

                int DivisionResult = Divide(num1, num2);
                Console.WriteLine($"The result of {number1} and {number2} is: {DivisionResult}");
            }
            // This exception for FormatExcpetion ensures that the format is correct. I thought that was very cool.
            catch (FormatException ex)
            {
                Console.WriteLine("Error: One or more of your inputs is not a valid integer, please try agian.");
                Console.WriteLine($"Your error message: {ex.Message}");
            }
            // This makes sure that the number is not 0, and if it is, it throws an error.
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: You cannot divide by a zero with doing division, please try again.");
                Console.WriteLine($"Error: Exception has been caught: {ex.Message}");
            }
            // This will catch an error, no matter what it is.

            catch (OverflowException ex)
            {
                Console.WriteLine("Error: You have entered a number(s) that were too big.");
                Console.WriteLine($"Error: The following exception has been caught: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: An unepexted error has been caught within the program.");
                Console.WriteLine($"Error: Your message is as follows: {ex.Message}");
            }

            Console.WriteLine("Please press any key to enter.");
            Console.ReadKey();
        }
         static int Divide(int a, int b)
        {
            return a / b;
        }


    }
}
