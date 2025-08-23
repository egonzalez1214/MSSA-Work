namespace Assignment_7._2._3 {
    internal class Program {
        /*
        Given two strings s and t, return true if t is an anagram of s,
        and false otherwise. An Anagram is a word or phrase formed by
        rearranging the letters of a different word or phrase, typically
        using all the original letters exactly once.
        --- Example 1 ---
        Input: s = "anagram", t = "nagaram"
        Output: true
        --- Example 2 ---
        Input: s = "rat", t = "car"
        Output: false 
        */
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");

            // case one
            string oneInputOne = "anagram",
                   oneInputTwo = "nagaram";
            DoesItAnagram(oneInputOne, oneInputTwo);
            Console.WriteLine("-------------------------");
            // case two
            string twoInputOne = "rat",
                   twoInputTwo = "car";
            DoesItAnagram(twoInputOne, twoInputTwo);
            Console.WriteLine("-------------------------");
            // case three
            string threeInputOne = "the eyes,",
                   threeInputTwo = "they see!";
            DoesItAnagram(threeInputOne, threeInputTwo);
            Console.WriteLine("-------------------------");
            // case four
            string fourInputOne = "abc123",
                   fourInputTwo = "321cba";
            DoesItAnagram(fourInputOne, fourInputTwo);
            Console.WriteLine("-------------------------");
            // case five
            string fiveInputOne = "Leet Coder",
                   fiveInputTwo = "Electrode";
            DoesItAnagram(fiveInputOne, fiveInputTwo);
            Console.WriteLine("-------------------------");
        }

        static void DoesItAnagram(string inputOne, string inputTwo) {
            bool IsAnagram = false;

            // strip to barebones for comp
            char[] stringOne = inputOne
                .ToLower()
                .Replace(" ", "")
                .Where(char.IsLetterOrDigit)
                .ToArray();
            Array.Sort(stringOne);
            char[] stringTwo = inputTwo
                .ToLower()
                .Replace(" ", "")
                .Where(char.IsLetterOrDigit)
                .ToArray();
            Array.Sort(stringTwo);

            // first check, if length not equal, no way anagram
            if (stringOne.Length == stringTwo.Length) {
                IsAnagram = AnagramChecker(inputOne, inputTwo, stringOne, stringTwo);
            }

            Console.WriteLine($"({inputOne}) | ({inputTwo})\n" +
                              $"IsAnagram: {IsAnagram}");
        }

        static bool AnagramChecker(string inputOne, string inputTwo,
                                   char[] stringOne, char[] stringTwo) {
            // default true since length check true
            bool IsAnagram = true;

            // check if stringOne = stringTwo, return false if not
            for (int i = 0; i < stringOne.Length; i++) {
                if (stringOne[i] != stringTwo[i]) {
                    IsAnagram = false;
                    break; // <--- break if false, no need keep checking
                }
            }

            // return if true or false
            return IsAnagram;
        }
    }
}
/*
This was a little hard to cover more cases for, and i dont think i have
covered for every case, but i got a lot of them. i think the logic came
to me pretty quickly, and i think my white board was a lot better.
*/