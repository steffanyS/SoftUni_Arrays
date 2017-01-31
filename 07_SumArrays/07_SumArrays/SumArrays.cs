using System;

namespace _07_SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            string[] firstStrArray = Console.ReadLine().Split(' ');
            string[] secondStrArray = Console.ReadLine().Split(' ');

            int[] firstArray = new int[firstStrArray.Length];
            int[] secondArray = new int[secondStrArray.Length];
            int[] sumArray = new int[Math.Max(firstArray.Length, secondArray.Length)];
            int count = 0;

            for (int i = 0; i < firstStrArray.Length; i++)
            {
                firstArray[i] = int.Parse(firstStrArray[i]);
            }

            for (int i = 0; i < secondStrArray.Length; i++)
            {
                secondArray[i] = int.Parse(secondStrArray[i]);
            }

            for (int i = 0; i < sumArray.Length; i++)
            {
                if (firstArray.Length < sumArray.Length)
                {
                    sumArray[i] = firstArray[count] + secondArray[i];
                    count++;
                    if (count == firstArray.Length)
                    {
                        count = 0;
                    }
                }
                else if (secondArray.Length < sumArray.Length)
                {
                    sumArray[i] = firstArray[i] + secondArray[count];
                    count++;
                    if (count == secondArray.Length)
                    {
                        count = 0;
                    }
                }
                else
                {
                    sumArray[i] = firstArray[i] + secondArray[i];
                }
            }

            foreach (var element in sumArray)
            {
                Console.Write(element + " ");
            }
        }
    }
}
