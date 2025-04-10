namespace Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var symbols = "pwwkew";
            int res = LengthOfLongestSubstring(symbols);
            Console.WriteLine(res);
        }
        public static int LengthOfLongestSubstring(string s)
        {
            if (s == "")
            {
                return 0;
            }
            else if (s == " ")
            {
                return 1;
            }
            if (s.Length == 1)
            {
                return 1;
            }
            int length = 0;
            int result = 0;
            List<char> list = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    list.Add(s[j]);
                    length++;

                    if (j + 1 == s.Length)
                    {
                        if (result < length)
                        {
                            result = length;
                        }
                        length = 0;
                        list.Clear();
                        break;
                    }
                    if (list.Contains(s[j + 1]))
                    {
                        if (result < length)
                        {
                            result = length;
                        }
                        length = 0;
                        list.Clear();
                        break;
                    }
                }
            }
            if (result == 0)
            {
                result += s.Length;
            }
            return result;
        }
    }
}