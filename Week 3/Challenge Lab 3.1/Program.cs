namespace Challenge_Lab_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            PalindromeChecker();
        }

        static void PalindromeChecker()
        {
            bool isPalindrome = false;
            //string checkPalindrome = "RACECAR";
            //string checkPalindrome = "ANNA";
            string checkPalindrome = "ROB";
            Console.WriteLine("Is " + checkPalindrome + " a palindrome?");
            char[] checkArray = checkPalindrome.ToCharArray();
            int arrayLength = checkArray.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = arrayLength - 1 - i; j >= 0; j--)
                {
                    if (checkArray[i] == checkArray[j])
                    {
                        isPalindrome = true;
                    }
                    else
                    {
                        isPalindrome = false;
                        break;
                    }
                }
            }
            string result = isPalindrome ? "is" : "is not";
            Console.WriteLine(checkPalindrome + " " + result + " a palindrome.");
        }
    }
}
