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
