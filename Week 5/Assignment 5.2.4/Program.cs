namespace Assignment_5._2._4 {

    internal class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");

            string inputString = "RADAR";
            //string inputString = "CAR"; //for testing
            
            //ternary operator; condition(IsPalindrome) true(?) false(:)
            Console.WriteLine(IsPalindrome(inputString)
                ? "The string is a Palindrome."
                : "The string is not a Palindrome");
        }

        static bool IsPalindrome(string input, int i = 0, int j = - 1) {
            //initializing j to input.Length since input is a runtime variable
            //decrementing by 1 each recursion after
            if (j == - 1) {
                j = input.Length - 1;
            }

            //code
            if (i >= j) {
                return true;
            }
            if (input[i] != input[j]) {
                return false;
            }

            //tail recursion
            return IsPalindrome(input, i + 1, j - 1);
        }
    }
}

/*
Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.
--- Test Data ---
Input a string: RADAR
Expected Output: The string is Palindrome.
*/