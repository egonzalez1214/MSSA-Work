namespace Assignment_7._2._2 {
    internal class Program {
        /*
        Given a string s, reverse only all the vowels in the string
        and return it. The vowels are 'a', 'e', 'i', 'o', and 'u',
        and they can appear in both lower and upper cases, more than once.
        --- Example 1 ---
        Input: s = "hello"
        Output: "holle"
        --- Example 2 ---
        Input: s = "avacado"
        Output: "ovacada"
        --- Example 3 ---
        Input: s = “intelligent”
        Output: entillegint
        */
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");

            // case one
            string inputOne = "hello"; // e|o ---> o|e
            SwitchTheVowels(inputOne);
            Console.WriteLine("-------------------------");
            // case two
            string inputTwo = "avacado"; // a|a|a|o ---> o|a|a|a
            SwitchTheVowels(inputTwo);
            Console.WriteLine("-------------------------");
            // case three
            string inputThree = "intelligent"; // i|e|i|e ---> e|i|e|i
            SwitchTheVowels(inputThree);
            Console.WriteLine("-------------------------");
            // bonus case
            string inputFour = "uPpErOrLoWeR"; // please
            SwitchTheVowels(inputFour);
        }

        // first attempt without looking up a solution
        static void SwitchTheVowels(string input) {
            // array to hold my vowels
            char[] vArray = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            // convert string to char array
            char[] iArray = input.ToCharArray();
            // list to better add each vowel for later
            List<char> tempList = new List<char>();

            // print original word
            foreach (char c in iArray) {
                Console.Write(c);
            }
            Console.WriteLine();
            
            // iterate through vowels, for each char in input string
            // replace vowels with '-', and get list of vowels
            for (int i = 0; i < iArray.Length; i++) {
                for (int j = 0; j < vArray.Length; j++) {
                    if (iArray[i] == vArray[j]) {
                        iArray[i] = '-';
                        tempList.Add(vArray[j]);
                    }
                }
            }

            // reverse list
            tempList.Reverse();

            // put the vowels back in
            for (int i = 0; i < iArray.Length; i++) {
                if (iArray[i] == '-') {
                    iArray[i] = tempList[0];
                    tempList.RemoveAt(0);
                }
            }

            // print new array with vowels reversed
            foreach (char c in iArray) {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
/*
Did a white board for this solution. Helped a little to understand what
i needed to do, but was still a bit confusing to implement. Had my arrays
in opposite order originally and got "entelligint" for case 3, so i had
to re-arrange how i looked for the vowels...
*/