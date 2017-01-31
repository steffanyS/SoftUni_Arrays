using System;
using System.Linq;

namespace _09_ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (array.Length == 1)
            {
                Console.Write("{{ {0} }}", array[0]);
            }

            if (array.Length == 3)
            {
                Console.Write("{{ {0}, {1}, {2} }}",array[0],array[1],array[2]);
            }

            if (array.Length % 2 == 0 && array.Length != 1)
            {
                Console.Write("{ ");
                for (int i = array.Length / 2 - 1; i <= array.Length / 2; i++)
                {
                    if (i < array.Length / 2)
                    {
                        Console.Write(array[i] + ", ");
                    }
                    else
                    {
                        Console.Write(array[i]);
                    }
                }
                Console.Write(" }");
            }

            if (array.Length % 2 != 0 && array.Length != 1 && array.Length!=3)
            {
                Console.Write("{ ");
                for (int i = array.Length / 3; i <= array.Length / 3 + 2; i++)
                {
                    if (i < array.Length / 3 + 2)
                    {
                        Console.Write(array[i] + ", ");
                    }
                    else
                    {
                        Console.Write(array[i]);
                    }
                }
                Console.Write(" }");
            }
        }
    }
}
