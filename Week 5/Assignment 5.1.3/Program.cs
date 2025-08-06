namespace Assignment_5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n");
            int[] inputArray1 = { 1, 2, 3, 1 };
            int[] inputArray2 = { 1, 2, 3, 4 };
            int[] inputArray3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            CheckForRepitition(inputArray1);
            CheckForRepitition(inputArray2);
            CheckForRepitition(inputArray3);
        }

        static void CheckForRepitition(int[] array) {
            Dictionary<int, int> Checker = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
                if (Checker.ContainsKey(array[i]))
                    Checker[array[i]]++;
                else
                    Checker[array[i]] = 1;

            bool isCounted = false;
            foreach (int value in Checker.Values)
                if (value > 1)
                    isCounted = true;
            Console.WriteLine(isCounted ? "True" :  "False");
            Console.WriteLine("---------------");
        }
    }
}

/*
Given an integer array nums, return true if any value appears at least
twice in the array, and return false if every element is distinct.
Example 1:
Input: nums = [1,2,3,1]
Output: true
Example 2:
Input: nums = [1,2,3,4]
Output: false
Example 3:
Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true 
*/