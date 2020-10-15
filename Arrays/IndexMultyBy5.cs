using System;

namespace Arrays
{
    class IndexMultyBy5
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}

