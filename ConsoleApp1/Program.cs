using System;

namespace LexicographicalComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputArr1 = "aaaaa aaaab aaaac ZZZZX ZZZZY ZZZZZ";
            string inputArr2 = "abc";

            char[] arr1 = inputArr1.ToCharArray();
            char[] arr2 = inputArr2.ToCharArray();

            int i = 0;
            int j = 0;
            bool equal = false;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] > arr2[j])
                {
                    Console.WriteLine(inputArr2);
                    equal = false;
                    break;
                }
                else if (arr1[i] < arr2[j])
                {
                    Console.WriteLine(inputArr1);
                    equal = false;
                    break;
                }
                else
                {
                    equal = true;
                }

                i++;
                j++;
            }

            if (equal == true)
            {
                if (arr1.Length < arr2.Length)
                {
                    Console.WriteLine(inputArr1);
                }
                else if (arr1.Length > arr2.Length)
                {
                    Console.WriteLine(inputArr2);
                }
                else
                {
                    Console.WriteLine("No difference");
                }
            }
        }
    }
}


