namespace Assignment_6._2._2 {

    internal class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");

            //case 1
            int[] inputNums1 = [1, 2, 3, 4]; //[24, 12, 8, 6]
            PrintArray(inputNums1);
            DoTheMath(inputNums1);
            Console.WriteLine();

            //case 2
            int[] inputNums2 = [-1, 1, 0, -3, 3]; //[0, 0, 9, 0, 0]
            PrintArray(inputNums2);
            DoTheMath(inputNums2);
            Console.WriteLine();
        }

        static void PrintArray(int[] nums) {
            foreach (int i in nums) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void DoTheMath(int[] nums) {
            //new array for products of nums array
            int[] prods = new int[nums.Length];

            int n = 1;
            for (int i = 0; i < nums.Length; i++) {
                prods[i] = n;
                n *= nums[i];
            }

            int m = 1;
            for (int i = nums.Length - 1; i >= 0; i--) {
                prods[i] *= m;
                m *= nums[i];
            }

            foreach (int i in prods) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

/*
Given an integer array nums, return an array answer such that answer[i] is equal
to the product of all the elements of nums except nums[i]. The product of any prefix
or suffix of nums is guaranteed to fit in a 32-bit integer. You must write an algorithm
that runs in O(n) time and without using the division operation.
--- Example 1 ---
Input: nums = [1,2,3,4]
Output: [24,12,8,6]
--- Example 2 ---
Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0] 
*/