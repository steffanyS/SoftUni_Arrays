using System;

namespace _03_LastKNumbersSums
{
    class LastNumbersSum
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] array = new long[n];
            array[0] = 1;
            long sum = 0l;


            for (int i = 1; i < array.Length; i++)
            {
                for (int j = Math.Max(i - k, 0); j < n; j++)
                {
                    sum += array[j];
                }

                array[i] = sum;
                sum = 0;
            }

            foreach (var number in array)
            {
                Console.Write(number + " ");
            }
        }
    }
}
