namespace Challenge_Lab_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n");

            //Case 1
            int[] inputNums1 = { 3, 0, 1 };
            FindTheMissingNumber(inputNums1);

            //Case 2
            int[] inputNums2 = { 0, 1 };
            FindTheMissingNumber(inputNums2);

            //Case 3
            int[] inputNums3 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            FindTheMissingNumber(inputNums3);
        }

        static void FindTheMissingNumber(int[] nums) {
            Dictionary<int, int> AllNumbers = new Dictionary<int, int>();
            int i = 0;
            while (i < nums.Length) {
                AllNumbers.Add(i, 0);
            }

            for (i = 0; i < nums.Length + 1; i++) {
                if (AllNumbers.ContainsKey(i)) {
                    AllNumbers[i]++;
                }
                else {
                    AllNumbers.Add(i, 0);
                }
            }

            foreach (int value in AllNumbers.Values) {
                if (value == 0) {
                    Console.WriteLine($"The missing number is: {AllNumbers.Key}.");
                }
            }
        }
    }
}

/*
Given an array nums containing n distinct numbers in the range [0, n],
return the only number in the range that is missing from the array.
--- Example 1 ---
Input: nums = [3,0,1]
Output: 2
Explanation: n = 3 since there are 3 numbers, so all numbers are in
the range [0,3]. 2 is the missing number in the range since it does
not appear in nums.
--- Example 2 ---
Input: nums = [0,1]
Output: 2
Explanation: n = 2 since there are 2 numbers, so all numbers are in
the range [0,2]. 2 is the missing number in the range since it does
not appear in nums.
--- Example 3 ---
Input: nums = [9,6,4,2,3,5,7,0,1]
Output: 8
Explanation: n = 9 since there are 9 numbers, so all numbers are in
the range [0,9]. 8 is the missing number in the range since it does
not appear in nums. 
*/