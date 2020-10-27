using System;
using System.Linq;
using System.Collections.Generic;

namespace ListManipulationAdvanced
{
    class Program
    {
        public static void Main()
        {
            int n = 5;
            int k = 3;
            var arr = new int[5] { 1, 2, 3, 4, 5 };
            var rotated = new int[5];
            var sum = new int[5];

            for (int i = 0; i < rotated.Length; i++)
            {
                rotated[i] = arr[i];
            }

            for (int j = 0; j < k; j++)
            {
                int last = 0;

                last = rotated[rotated.Length - 1];

                for (int i = rotated.Length - 1; i > 0; i--)
                {
                    rotated[i] = rotated[i - 1];
                }
                rotated[0] = last;
                foreach (var item in rotated)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine();
                for (int i = 0; i < sum.Length; i++)
                {
                    sum[i] += rotated[i];
                }
            }
            foreach (var item in sum)
            {
                Console.Write(item + ", ");
            }
        }
    }
}