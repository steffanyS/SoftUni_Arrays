using System;
using System.Linq;

namespace _05_RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            double[] array = numbers.Split(' ').Select(Double.Parse).ToArray();

            var roundedNums = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                roundedNums[i] = Math.Round(array[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < roundedNums.Length; i++)
            {
                Console.WriteLine("{0} => {1}", array[i], roundedNums[i]);
            }
        }
    }
}
