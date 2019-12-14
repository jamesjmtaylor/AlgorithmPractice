using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] array = new int[] { 4, 1, 3, 10, -4, 29,1 };
            int[] helper = new int[array.Length];
            Sorter.MergeSort(array, helper, 0, array.Length - 1);
            Console.WriteLine($"Sorted: {String.Join(",", array)}");*/
            int a = 2;
            int b = 3;
            Console.WriteLine($"{a} plus {b} is {BitOp.Add(a,b)}");
            Console.WriteLine($"{a} negated is {BitOp.Negate(a)}");
            Console.WriteLine($"Bit at position {a} of {b} is {BitOp.GetBitAt(a, b)}");
        }


    }
}
