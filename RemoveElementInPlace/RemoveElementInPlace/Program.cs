public class Program
{
    public static void Main(string[] args)
    {
        int num = 16;
        IsPowerOfFour(num);
    }
    public static int RemoveElement(int[] nums, int val)
    {
        int write = 0;
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[write] = nums[i];
                k++;
                write++;
            }
        }
        return k;
    }
    public static int LengthOfLastWord(string s)
    {
        int k = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                k++;
                continue;
            }
            if (k >0)
                break;
        }
        return k;
    }
    public static bool IsPowerOfFour(int n)
    {
        if (n == 1)
        {
            return true;
        }
        if (n <= 0 || n % 4 != 0)
        {
            return false;
        }
        return IsPowerOfFour(n / 4);
    }
}