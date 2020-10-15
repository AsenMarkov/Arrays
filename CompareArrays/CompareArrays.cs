using System;
using System.Buffers;
using System.Threading;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 0 };
            int[] arr2 = new int[] { -0 };
            int count = 0;

            if (arr1.Length != arr2.Length)
            {
                Console.WriteLine("False");
                return;
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        count++;
                    }
                }
            }
            if (count == arr1.Length)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
