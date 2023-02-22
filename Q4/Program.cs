namespace Q4
{
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] words = { "", "rortor", "abba", "absba", "q" };// test a few combinations

            for (int i = 0; i < words.Length; i++)
            {
                if (IsPalindrome(words[i]))
                {

                    WriteLine(words[i] + " is a palindrome");
                }
                else
                {
                    WriteLine(words[i] + " is not a palindrome");
                }

            }
            ReadLine();

        }

        /// <summary>
        /// Checks if a string is a palindrome
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        static bool IsPalindrome(string word)
        {
            bool pal = true;

            if (word == null)
            {
                return false;
            }

            int j = word.Length - 1;

            for (int i = 0; i < word.Length / 2; i++)

            {

                if (word[i] != word[j])
                {
                    pal = false;
                }
                j--;
            }
            return pal;
        }
    }
}