namespace Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 5, 5, 11 };
            var res = TwoSum(nums, 10);
            foreach (int x in res)
            {
                Console.WriteLine(x);
            }
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int j = 0; j < nums.Length; j++)
            {
                for (int i = j + 1; i < nums.Length; i++)
                {
                    if (nums[j] + nums[i] == target)
                    {
                        result[0] = j;
                        result[1] = i;

                        return result;
                    }
                }
            }
            return result;
        }
    }
}
