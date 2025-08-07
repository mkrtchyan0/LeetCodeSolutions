namespace LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "", "b" };
            Console.WriteLine(LongestCommonPrefix(strs));
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null)
            {
                return "";
            }
            if (strs.Length == 1)
            {
                return strs[0];
            }
            string result = "";
            int current = 0;

            string firstWord = strs[0];
            while (current < firstWord.Length)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (current >= strs[j].Length || firstWord[current] != strs[j][current])
                    {
                        return result;
                    }
                }
                result += firstWord[current];
                current++;
            }
            return result;
        }
    }
}
