using System;
using System.Linq;
using System.Threading;

namespace _04_TrippleSum
{
    class TrippleSum
    {
        static void Main(string[] args)
        {
            string[] stringArr = Console.ReadLine().Split(' ');
            int[] arr = new int[stringArr.Length];
            int count = 0;

            for (int i = 0; i < stringArr.Length; i++)
            {
                arr[i] = int.Parse(stringArr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] == arr[k] && i != j == true && j != k == true)
                        {
                            if (i < j)
                            {
                                Console.WriteLine("{0} + {1} == {2}", arr[i], arr[j], arr[k]);
                                count++;
                                break;
                            }
                        }
                    }
                }
                if (i == arr.Length - 1 && count == 0)
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}

