using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ReverseStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

            var holder =' ';

            for (int i = 0; i < input.Length; i++)
            {
                holder = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = holder;
            }
        }
    }
}
