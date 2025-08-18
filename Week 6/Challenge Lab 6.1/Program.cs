using System.Numerics;

namespace Challenge_Lab_6._1 {

    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");

            int[,] rubiks = new int[3, 3] { // <--- There seems to be no pattern...
                { 1, 2, 3 }, // { 7, 4, 1 } <-- (+2, +4, +6) 3x3 = 9-1 = 8/3 = 2.67
                { 4, 5, 6 }, // { 8, 5, 2 } <-- (+7, +0, +2) i+2, i+3, i+4, i+4, i+0,
                { 7, 8, 9 }  // { 9, 6, 3 } <-- (+3, +5, +7) i+2, i+3(ovfl), i+5(ovfl), i+7(ovfl)
            };
            PrintTheFace(rubiks);
            //SpinTheRubiks(rubiks);
            Console.WriteLine("-------------------------");
            HowToReallySpinRubiks(rubiks);

            Console.WriteLine("\n");

            int[,] notRubiks = new int[4, 4] {
                { 5, 1, 9, 11 },   // { 15, 13,  2,  5 } <-- (+ 3, + 6, + 9, +12) 4x4 = 16-1 = 15/4 = 3.75
                { 2, 4, 8, 10 },   // { 14,  3,  4,  1 } <-- (+14, + 1, + 4, + 7)
                { 13, 3, 6, 7 },   // { 12,  6,  8,  9 } <-- (+ 9, +12, +15, + 2)
                { 15, 14, 12, 16 } // { 16,  7, 10, 11 } <-- (+ 4, + 7, +10, +13)
            };
            PrintTheFace(notRubiks);
            //SpinTheRubiks(notRubiks);
            Console.WriteLine("-------------------------");
            HowToReallySpinRubiks(notRubiks);
        }
        static void PrintTheFace(int[,] array) {
            int maxValue = array[0, 0];
            for (int r = 0; r < array.GetLength(0); r++) {
                for (int c = 0; c < array.GetLength(1); c++) {
                    if (array[r, c] > maxValue) {
                        maxValue = array[r, c];
                    }
                }
            }
            int padding = maxValue.ToString().Length;
            //Console.WriteLine($"{maxValue} {padding}");

            for (int r = 0; r < array.GetLength(0); r++) {
                Console.Write("|");
                for (int c = 0; c < array.GetLength(1); c++) {
                    Console.Write($"{array[r, c]}|".PadLeft(padding + 1));
                }
                Console.WriteLine();
            }
        }
        static void SpinTheRubiks(int[,] array) {
            int size = array.GetLength(0) * array.GetLength(1);
            int[] strippedArray = new int[size];
            int i = 0;

            for (int r = 0; r < array.GetLength(0); r++) {
                for (int c = 0; c < array.GetLength(1); c++) {
                    strippedArray[i] = array[r, c];
                    i++;
                }
            }

            Console.Write("\n|");
            i = 0;
            for (i = 0; i < strippedArray.Length; i++) {
                Console.Write($" {strippedArray[i]} |");
            }
            Console.WriteLine();
        }

        static void HowToReallySpinRubiks(int[,] array) {
            for (int r = 0; r < array.GetLength(0); r++) {
                for (int c = r+1; c < array.GetLength(1); c++) {
                    int temp = array[r, c];
                    array[r, c] = array[c, r];
                    array[c, r] = temp;
                }
            }
            for (int r = 0; r < array.GetLength(0); r++) {
                int left = 0;
                int right = array.GetLength(0) - 1;
                while (left < right) {
                    int othertemp = array[r, left];
                    array[r, left] = array[r, right];
                    array[r, right] = othertemp;
                    left++; right--;
                }
            }
            //this was so far out of sight for me i was not even close
            //on top of that i was ilegally stripping the matrix into a 1d array
            //looking at the solution now, its crazy to see how simple things can really be
            //i could not for the life of me find the patter here...

            int maxValue = array[0, 0];
            for (int r = 0; r < array.GetLength(0); r++) {
                for (int c = 0; c < array.GetLength(1); c++) {
                    if (array[r, c] > maxValue) {
                        maxValue = array[r, c];
                    }
                }
            }
            int padding = maxValue.ToString().Length;

            for (int r = 0; r < array.GetLength(0); r++) {
                Console.Write("|");
                for (int c = 0; c < array.GetLength(1); c++) {
                    Console.Write($"{array[r, c]}|".PadLeft(padding + 1));
                }
                Console.WriteLine();
            }
        }
    }
}
