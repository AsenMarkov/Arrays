using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Transactions;

namespace SumOfLongestSeq
{
    class SumOfLongestSeq
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K:");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sumAtm = 0;
            int index = 0;
            int Sum = 0;
            int elementsCount = 1;

            for (int i = 0; i <= n - k; i++)
            {
                int j = i;
                for (; j < i + k; j++)
                {
                    sumAtm += arr[j];
                }

                if (sumAtm > Sum)
                {
                    index = i;
                    Sum = sumAtm;
                    elementsCount = j - i;
                }
                sumAtm = 0;
            }
            Console.Write("The max sum is: {0}, and the sequence is: ", Sum);
            for (int i = index; i < index + elementsCount; i++)
            {
                if (i != index + elementsCount - 1)
                {    
                    Console.Write(arr[i] + " ");
                }
                else
                {
                    Console.Write(arr[i]);
                }

            }
        }
    }
}
