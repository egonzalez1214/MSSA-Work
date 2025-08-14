namespace Assignment_6._1._3 {

    internal class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");
            
            //case one
            int[] inputNums1 = [ 0, 1, 0, 3, 12 ];
            BeforeBigShift(inputNums1);
            ShiftTheZeros(inputNums1);

            //case two
            int[] inputNums2 = [0];
            BeforeBigShift(inputNums2);
            ShiftTheZeros(inputNums2);
        }

        static void BeforeBigShift(int[] nums) {
            //Print unshifted array
            Console.WriteLine("Numbers before shifting the zeros:");
            foreach (int i in nums) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void ShiftTheZeros(int[] nums) {
            //shift zeros back
            int theZero = 0; //<--- zero index and place holder
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] != 0) {
                    if (i != theZero) {
                        nums[theZero] = nums[i]; //<--- shifts number to zero index
                        nums[i] = 0; //<--- sets current index to zero
                    }
                    theZero++; //<--- increments zero index
                }
            }

            //print shifted array
            Console.WriteLine("Numbers after shifting the zeros:");
            foreach (int i in nums) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
