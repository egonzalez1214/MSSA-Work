using System.Text;

namespace Assignment_7._1._2 {
    internal class Program {
        /*
        You are given two strings word1 and word2. Merge the strings by adding
        letters in alternating order, starting with word1. If a string is longer
        than the other, append the additional letters onto the end of the merged
        string. Return the merged string.
        --- Example 1 ---
        Input: word1 = "abc", word2 = "pqr"
        Output: "apbqcr"
        Explanation: The merged string will be merged as so:
        --- Example 2 ---
        Input: word1 = "ab", word2 = "pqrs"
        Output: "apbqrs"
        Explanation: Notice that as word2 is longer, "rs" is appended to the end.
        */
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");

            //case one
            string wordOne = "abc";
            string wordTwo = "pqr";
            FusionDance(wordOne, wordTwo);
            Console.WriteLine("\n-------------------------\n");
            //case two
            string word1 = "ab";
            string word2 = "pqrs";
            FusionDance(word1, word2);
        }

        static void FusionDance(string string1, string string2) { //<-- my first attempt
            //got recommended to use stringbuilder... trying it... should use it more...
            int maxLength = string1.Length + string2.Length;
            var builtString = new StringBuilder(maxLength);
            /* this is dumb...
            int maxLength = string1.Length + string2.Length; //added the max lenght...
            string[] string3 = new string[maxLength]; //tried making a new array
            for (int i = 0; i < maxLength; i++) {
                for (int j = 0; j < string2.Length; j++) {
                    string3[i] = String.Concat(string1[i], string2[j]);
                    }
                }
            }
            this attempt didnt go anywhere, and i couldn't get it to work...
            */
            for (int i = 0; i < maxLength; i++) {
                //adds letter in element 0 of string1 to builtString
                //for short case... since empty, just goes to next if
                if (i < string1.Length) {
                    builtString.Append(string1[i]); //<-- While looking how to add strings
                }                                   //<-- saw Append method...
                //adds letter in element 0 of string2 after string1
                //since final if, stops looping at maxLength
                if (i < string2.Length) {
                    builtString.Append(string2[i]);
                }
            }

            Console.Write("|");
            for (int i = 0; i < maxLength; i++) { //<-- failed to write working foreach...
                Console.Write($" {builtString[i]} |");
            }
            Console.WriteLine();
        }
        /*
        Needed a lot of help with the stringbuilder... but ended up with a really good
        solution... i left my original attempt in here, but it doesnt work and was a
        little silly to begin with. but after going through this i can fix my old method
        by setting a bigger length...
        */
    }
}
