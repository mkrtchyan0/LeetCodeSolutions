namespace ReverseInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int final = Reverse(1534236469);
            Console.WriteLine(final);
        }
        public static int Reverse(int x)
        {
            if (x > Int32.MaxValue || x < Int32.MinValue)
            {
                return 0;
            }

            string num = x.ToString();
            string res = null;

            if (x < 0)
            {
                for (int i = num.Length - 1; i > 0; i--)
                {
                    res += num[i];
                }
                long result2 = long.Parse(res);
                result2 *= -1;
                if (result2 > Int32.MaxValue || result2 < Int32.MinValue)
                {
                    return 0;
                }
                else
                {
                    int finalResult1 = int.Parse(res);
                    return finalResult1 * -1;
                }
            }
            else
            {
                for (int i = num.Length - 1; i >= 0; i--)
                {
                    res += num[i];
                }
            }
            long result = long.Parse(res);
            if (result > Int32.MaxValue || result < Int32.MinValue)
            {
                return 0;
            }
            int finalResult = int.Parse(res);
            return finalResult;
        }
    }
}
