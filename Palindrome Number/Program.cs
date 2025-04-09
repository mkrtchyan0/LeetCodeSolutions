namespace Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = IsPalindrome(91919);
            Console.WriteLine(x);
        }
        public static bool IsPalindrome(int x)
        {
            string num = x.ToString();
            var reversed = new System.Text.StringBuilder();

            for (int i = num.Length - 1; i >= 0; i--)
            {
                reversed.Append(num[i]);
            }

            return num == reversed.ToString();
        }
    }
}
