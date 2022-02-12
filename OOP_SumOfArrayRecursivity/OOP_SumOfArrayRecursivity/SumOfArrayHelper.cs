using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SumOfArrayRecursivity
{
    public static class SumOfArrayHelper
    {
        public static int SumOfArray(int[] array, int size, int index = 0)
        {
            int sum = 0;

            if (array is null || array.Length == 0)
            {
                return -1;
            }

            if (index == size - 1)
            {
                return array[index];
            }

            if (index < array.Length)
            {
                sum = SumOfArray(array, size, index + 1);
                sum += array[index];
            }

            return sum;
        }
    }
}
