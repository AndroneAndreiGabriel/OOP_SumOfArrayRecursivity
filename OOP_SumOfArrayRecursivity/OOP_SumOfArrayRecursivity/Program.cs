using System;

namespace OOP_SumOfArrayRecursivity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = SumOfArrayHelper.SumOfArray(array, array.Length);
            Console.WriteLine($"Sum of vector elements: {sum}");
        }
    }
}
