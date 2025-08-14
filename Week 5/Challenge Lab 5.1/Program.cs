namespace Challenge_Lab_5._1 {

    internal class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");

            //case 1
            int[] inputArray1 = { 2, 2, 1 };
            FindSoloElement(inputArray1);
            Console.WriteLine();

            //case 2
            int[] inputArray2 = { 4, 1, 2, 1, 2 };
            FindSoloElement(inputArray2);
            Console.WriteLine();

            //case 3
            int[] inputArray3 = { 1 };
            FindSoloElement(inputArray3);
        }

        static void FindSoloElement(int[] array) {
            //print array for viewing
            for (int i = 0; i < array.Length; i++) {
                Console.Write($"| {array[i]} ");
            }
            Console.WriteLine("|");

            //create dictionary to hold element and element count
            Dictionary<int, int> elementCount = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++) {
                if (elementCount.ContainsKey(array[i])) {
                    elementCount[array[i]]++;
                }
                else {
                    elementCount[array[i]] = 1;
                }
            }

            //using kvp: key value pairs, i can get both the key (array element)
            //and the value (the count of how many times it appears)
            foreach (var kvp in elementCount) {
                if (kvp.Value == 1) {
                    Console.WriteLine($"Solo Element: ' {kvp.Key} ' appears {kvp.Value} time.");
                }
            }
        }

        /*
        static int FindUniqueValue(int[] array) {
            int result = 0;
            foreach (int num in array) {
                result ^= num;
            }
            return result;
        }
        */
    }
}

/*
Given a non-empty array of integers nums, every element
appears twice except for one. Find that single one.
--- Example 1 ---
Input: nums = [2,2,1]
Output: 1
--- Example 2 ---
Input: nums = [4,1,2,1,2]
Output: 4
--- Example 3 ---
Input: nums = [1]
Output: 1 
*/