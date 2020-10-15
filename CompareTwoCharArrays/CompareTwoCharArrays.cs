using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace CompareTwoCharArrays
{
    class CompareTwoCharArrays
    {
        static void Main(string[] args)
        {
            string str1= "aaaaa aaaab aaaac ... ZZZZX ZZZZY ZZZZZ";
            string str2 = "abc";

            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();

            int i = 0;
            int j = 0;
            bool same = false;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] > arr2[j])
                {
                    Console.WriteLine(str2);
                    same = false;
                    break;
                }
                else if (arr1[i] < arr2[j])
                {
                    Console.WriteLine(str1);
                    same = false;
                    break;
                }
                else
                {
                    same = true;
                }
                i++;
                j++;
            }
                if (same == true)
                {
                    if (arr1.Length > arr2.Length)
                    {
                        Console.WriteLine(str1);

                    }
                    else if (arr1.Length < arr2.Length)
                    {
                        Console.WriteLine(str2);
                    }
                    else
                    {
                        Console.WriteLine("The arrays are the same!");
                    }
                } 
        }
    }
}
