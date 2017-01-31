using System;
using System.Linq;

namespace _08_CondenseArrayToNumber
{
    class Condense
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] modifiedNums = new int[nums.Length];

            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < modifiedNums.Length - i -1; j++)
                {
                    modifiedNums[j] = nums[j] + nums[j + 1];
                }
                nums = modifiedNums;
            }

            Console.WriteLine(nums[0]);
        }

    }

}

