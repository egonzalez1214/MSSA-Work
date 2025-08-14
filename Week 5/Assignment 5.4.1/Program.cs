namespace Assignment_5._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n");

            int inputNumber = 1234567;
            NumbersThroughRecursion(inputNumber);
        }

        static void NumbersThroughRecursion(int number) {
            //edge case
            if (number <= 0) {
                return;
            }
            
            //length of number given
            int numberLength = number.ToString().Length;

            //getting the first digit of input number and printing it
            int digit = number / (int)Math.Pow(10, numberLength - 1);
            Console.Write(digit + " ");

            //tail recursion
            //this gets number, gets 10^power of numberLength - 1, and modulos it
            //for the remaining digits, cutting the first digit every time
            NumbersThroughRecursion(number % (int)Math.Pow(10, numberLength - 1));
        }
    }
}

/*
Write a program in C# Sharp to display the individual digits of a given number using recursion.
--- Test Data ---
Input any number: 1234
Expected Output:
The digits in the number 1234 are: 1 2 3 4
*/