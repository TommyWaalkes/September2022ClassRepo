namespace PigLatin
{
    internal class Program
    {

        //As we learn more and more, the job of main shrinks to delegating calls to methods and our continue loop
        static void Main(string[] args)
        {
            bool keepGoing = true;

            while (keepGoing == true)
            {
                string input = GetUserInput("Hello, please input a word or sentence to translate into Pig Latin.");

                //Split without params does whitespace 
                string[] words = input.Split();

                //Split out our sentence into individual words and translate them
                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    if (CanTranslate(word) == true)
                    {
                        string pigLatinWord = Translate(word);
                        Console.Write(pigLatinWord + " ");
                    }
                    else
                    {
                        Console.Write(word + " ");
                    }
                }
                Console.WriteLine();


            }
            //Console.WriteLine(FindVowelPosition("hello"));
            //Console.WriteLine(FindVowelPosition("Sky"));
            //Console.WriteLine(FindVowelPosition("Strong"));
            //Console.WriteLine(FindVowelPosition("Peach"));
            //Console.WriteLine(FindVowelPosition("Apple"));


        }

        //ContainsVowe()l 
        //IsVowel(char c) 

        //FindVowelPosition() 

        //Message is what prompts the user
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().Trim();

            return input;
        }


        public static bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            bool isVowel = vowels.Contains(c);

            return isVowel;
        }

        public static int FindVowelPosition(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                bool isVowel = IsVowel(c);
                if (isVowel == true)
                {
                    return i;
                }
            }

            //Say we get through the whole word and no vowels are found 
            return -1;
        }

        public static string Translate(string word)
        {
            int pos = FindVowelPosition(word);
            string result = "";
            //This means our word starts with a vowel
            if (pos == 0)
            {
                result = word + "way";
            }
            else if (pos == -1)
            {
                Console.WriteLine("No vowel was found, skipping translating this word");
                result = word;
            }
            else if (pos > 0)
            {
                //We know the position of the first vowel, we want to cut off everything before it 
                //and move it to the end. 
                //strong 
                string prefix = word.Substring(pos);
                string postFix = word.Substring(0, pos);
                result = prefix + postFix + "ay";
            }

            //Console.WriteLine(result);

            return result;
        }

        public static bool CanTranslate(string word)
        {
            char[] verbotenChars = "1234567890@#$%^&*()".ToCharArray();

            foreach (char c in verbotenChars)
            {
                if (word.Contains(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}