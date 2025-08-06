namespace Challenge_Lab_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SeparateThePairs();
        }

        static void SeparateThePairs()
        {
            bool doesNeedSplit;
            string inputString = "ABFCACDB";
            Console.WriteLine("Input string is: " + inputString);
            do
            {
                doesNeedSplit = false;
                if (inputString.Contains("AB"))
                {
                    inputString = inputString.Replace("AB", "");
                    doesNeedSplit = true;
                }
                if (inputString.Contains("CD"))
                {
                    inputString = inputString.Replace("CD", "");
                    doesNeedSplit = true;
                }
            } while (doesNeedSplit == true);
            int finalStringLength = inputString.Length;
            Console.WriteLine("Output string is: " + inputString);
            Console.WriteLine("String length is: " + finalStringLength);
        }
    }
}

/*
You are given a string s consisting only of uppercase English letters. You can apply
some operations to this string where, in one operation, you can remove any occurrence
of one of the substrings "AB" or "CD" from s. Return the minimum possible length of the
resulting string that you can obtain. Note that the string concatenates after removing
the substring and could produce new "AB" or "CD" substrings.
*** Hint: Use Replace method of string ***
----- Example 1 -----
Input: s = "ABFCACDB"
Output: 2
Explanation: We can do the following operations...
   - Remove the substring "ABFCACDB", so s = "FCACDB".
   - Remove the substring "FCACDB", so s = "FCAB".
   - Remove the substring "FCAB", so s = "FC".
So the resulting length of the string is 2, the minimum length that we can obtain.
----- Example 2 -----
Input: s = "ACBBD"
Output: 5
Explanation: We cannot do any operations on the string so the length remains the same. 
*/