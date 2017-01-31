using System;

namespace _02_ReverseArrayOfIntegers
{
    class IntArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = n-1; i >=0; i--)
            {
                Console.Write("{0} ",array[i]);
            }
        }
    }
}
