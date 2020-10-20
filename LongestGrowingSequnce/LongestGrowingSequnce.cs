using System;
using System.Threading;

namespace LongestSequenceOfSameElements
{
    class LongestGrowingSequnce
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 2, 3, 4, 2, 2, 4 };
            int count = 0;
            int maxCount = 0;
            int index = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                count = 1;
                int j = i+1;
                int z = i;

                while (arr[z] < arr[j])
                {
                    count++;
                    j++;
                    z++;
                    if (j >= arr.Length)
                    {
                        break;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    index = i;
                }
            }



            for (int i = index; i < index + maxCount; i++)
            {
                if (i != index + maxCount - 1)
                {
                    Console.Write(arr[i] + ", ");
                }
                else
                {
                    Console.WriteLine(arr[i]);
                }
            }

        }
    }
}
