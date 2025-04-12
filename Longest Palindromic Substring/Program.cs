namespace Longest_Palindromic_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = LongestPalindrome("babad");
            Console.WriteLine(res);
        }
        public static string LongestPalindrome(string s)
        {
            int count = s.Length;
            int currentCount = 1;
            string result = "";
            int b = 0;

            if (s.Length == 1)
            {
                return s;
            }
            List<char> charikner1 = new List<char>();
            List<char> charikner2 = new List<char>();
            while (currentCount != count)
            {
                for (int k = b; k <= currentCount; k++)
                {
                    charikner1.Add(s[k]);
                }
                for (int k = currentCount; k >= b; k--)
                {
                    charikner2.Add(s[k]);
                }
                b++;

                string left = new string(charikner1.ToArray());
                string right = new string(charikner2.ToArray());

                if (left == right)
                {
                    if (result.Length < left.Length)
                    {
                        result = left;
                    }

                    currentCount++;
                    b = 0;                    
                }
                if (b == count)
                {
                    currentCount++;
                    b = 0;
                }
                charikner1.Clear();
                charikner2.Clear();
            }
            return result;
        }
    }
}