namespace ConsoleApp1 {

    internal class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");
            WhoAreWeRobbing();
        }

        ///*
        static void WhoAreWeRobbing() {
            Dictionary<int, List<int>> houseMoney = new Dictionary<int, List<int>>();
            int[] nums = new int[] { 2, 5, 9, 3, 1 };

            for (int i = 0; i < nums.Length - 2; i++) {
                int sum = nums[i];
                List<int> houses = new List<int> { nums[i] };
                for (int j = i + 2; j < nums.Length; j += 2) {
                    sum += nums[j];
                    houses.Add(nums[j]);
                }
                houseMoney[sum] = houses;
            }

            int maxMoney = houseMoney.Keys.Max();
            List<int> bestHouses = houseMoney[maxMoney];
            Console.Write("Houses to rob for max money: ");
            foreach (int house in bestHouses) {
                Console.Write(house + " ");
            }
            Console.WriteLine($"\nTotal Money: {maxMoney}");
        }
        //*/

        /*
        static void WhoAreWeRobbing() {
            int[] array = new int[] { 2, 5, 9, 3, 1 };
            int totalMoney = 0;
            int valueHouse = 0;
            HashSet<int> Houses;
            while (Houses.Count() != array.Length) {
                for (int i = 0; i < array.Length; i++) {
                    if (Houses.Contains(i)) {
                        continue;
                    }
                    if (array[i] > array[valueHouse]) {
                        valueHouse = i;
                    }
                }
                switch (valueHouse) {
                    case int n when (n == 0):
                        Houses.Add(valueHouse);
                        Houses.Add(valueHouse + 1);
                        break;
                    case int n when (n == array.Length - 1):
                        Houses.Add(valueHouse);
                        Houses.Add(valueHouse - 1);
                        break;
                    default:
                        Houses.Add(valueHouse);
                        Houses.Add(valueHouse - 1);
                        Houses.Add(valueHouse + 1);
                        break;
                }
                totalMoney += array[valueHouse];
                WhoAreWeRobbing(array, Houses, totalMoney);
            }
            Console.WriteLine($"Total Money: {totalMoney}");    
        }
        */

        /*
        static void Something() {
            static void Main(string[] args) {
                int[] arr = { 0, 3, 3, 6, 6, 8 };
                Console.WriteLine($"The smallest index with mathing value is at index: {FindIndexValueMatch(arr)}");
                int[] arr2 = { 1, 3, 3, 6, 4, 8 };
                Console.WriteLine($"The smallest index with mathing value is at index: {FindIndexValueMatch(arr2)}");
                int[] arr3 = { 1, 3, 3, 6, 6, 8 };
                Console.WriteLine($"The smallest index with mathing value is at index: {FindIndexValueMatch(arr3)}");
            }
            static int FindIndexValueMatch(int[] intArray) {
                for (int i = 0; i < intArray.Length; i++) {
                    if (i == intArray[i]) {
                        return i;
                    }
                }
                return -1;
            }
        }
        */
    }
}

/*
You are a professional robber planning to rob houses along a street. Each house
has a certain amount of money stashed, the only constraint stopping you from robbing
each of them is that adjacent houses have security systems connected and it will
automatically contact the police if two adjacent houses were broken into on the same night.
Given an integer array nums representing the amount of money of each house, return the
maximum amount of money you can rob tonight without alerting the police.
--- Example 1 ---
Input: nums = [1,2,3,1]
Output: 4
Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
Total amount you can rob = 1 + 3 = 4.
--- Example 2 ---
Input: nums = [2,7,9,3,1]
Output: 12
Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
Total amount you can rob = 2 + 9 + 1 = 12.
*/