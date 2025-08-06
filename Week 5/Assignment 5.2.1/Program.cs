namespace Assignment_5._2._1 {
    
    internal class Program {
        
        static void Main(string[] args) {
            Console.WriteLine("Hello World!\n");
            string inputString1 = "Hello World";
            string inputString2 = " fly me to the moon ";
            StringHowLong(inputString1);
            StringHowLong(inputString2);
        }

        static void StringHowLong(string input) {
            string[] inputArray = input.Trim().Split(' ');
            string finalWord = inputArray[inputArray.Length - 1];
            int letterCount = finalWord.Length;
            Console.WriteLine("Input: " + input);
            Console.WriteLine("Output: " + letterCount);
            Console.WriteLine($"Explanation: The last word is ''{finalWord}'' with length ''{letterCount}''");
            Console.WriteLine("--------------------");
        }
    }
}

/*
Given a string s consisting of words and spaces, return the length of
the last word in the string. A word is a maximal substring consisting
of non-space characters only.
------------------------------------------------------------
Example 1:
Input: s = "Hello World"
Output: 5
Explanation: The last word is "World" with length 5.
------------------------------------------------------------
Example 2:
Input: s = " fly me to the moon "
Output: 4
Explanation: The last word is "moon" with length 4. 
*/