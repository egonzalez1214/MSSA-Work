namespace Assignment_5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            GetIntPalindrome();
            Console.WriteLine();
            GetOtherPalindrome();
            Console.WriteLine();
        }

        static void GetIntPalindrome()
        {
            string butIsIt = "is not a Palendrome.";
            int x = 121;
            int num3 = x % 10;
            int num2 = (x / 10) % 10;
            int num1 = (x / 100) % 10;
            if (num1 == num3)
            {
                butIsIt = "is a Palendrome.";
            }
            Console.WriteLine($"{x} {butIsIt}");
        }

        static void GetOtherPalindrome()
        {
            Console.WriteLine("Please input a number: ");
            int userNum = int.Parse(Console.ReadLine());
            int tempNum = userNum;
            int count = 0;
            while (tempNum > 0)
            {
                tempNum = tempNum / 10;
                count++;
            }
            //Console.WriteLine(tempNum);
            //Console.WriteLine(count);
            double num1;
            double num2;
            double tempNum2 = userNum;
            bool isPalindrome = false;
            do
            {
                num1 = (int)(Math.Truncate(tempNum2 / Math.Pow(10, (count - 1))));
                num2 = (int)((tempNum2 % 10));
                //Console.WriteLine(num1 + " " + num2);
                if (num1 == num2)
                {
                    tempNum2 = Math.Truncate((tempNum2 % Math.Pow(10, (count - 1))) / 10);
                    count -= 2;
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            } while((count / 2) > 0);
            if (isPalindrome == true)
            {
                Console.WriteLine($"{userNum} is a Palindrome.");
            }
            else
            {
                Console.WriteLine($"{userNum} is not a Palindrome.");
            }
        }

        /*
        static bool IsPalindrome(int target)
        {
            int reverse = 0;
            int num = target;
            while (num > 0)
            {
                reverse = reverse * 10 + num % 10;
                num /= 10;
            }
            return reverse == target;
        }

        static int GetSumOfDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum = sum + n % 10;
                n /= 10;
            }
            return sum;
        }

        static int FactRecursion(int n) //Other Solution
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n + FactRecursion(n - 1);
        }
        */
    }
}

/*
Given an integer x, return true if x is a palindrome, and false otherwise.
Example 1:
Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
*/