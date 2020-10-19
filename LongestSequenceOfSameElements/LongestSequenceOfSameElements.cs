using System;
using System.Threading;

namespace LongestSequenceOfSameElements
{
    class LongestSequenceOfSameElements
    {
        static void Main(string[] args)
        {
            int[] arr = new int []{ 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            int count = 0;
            int maxCount = 0;
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                count = 0;
                int j = i;

                while (arr[i] == arr[j])
                {
                    count++; 
                    j++;
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

                for (int i = index; i < index+maxCount; i++)
                {
                    if (i != index + maxCount -1)
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
