using System;
using System.Collections.Immutable;
using System.Linq;
using System.Transactions;

namespace FoldingAndSumming
{
    class FoldingAndSumming
    {
        static void Main(string[] args)
        {
            Console.Write("Enter k:");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter the array of {0} numers:", 4*k);
            var mainArr = new int[4*k];
            mainArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var arrTop = new int[2 * k];
            var arrBottom = new int[2 * k];
            var revArr = mainArr.Reverse().ToArray();
            int lenghtArrTop = arrTop.Length; 
            int lenghtRevArr = revArr.Length; 
            int lenghtMainArr = mainArr.Length; 
            var sumArr = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                arrTop[lenghtArrTop - k] = revArr[i];
                lenghtArrTop++;
            }
            for (int j = 0; j < k; j++)
            {
                arrTop[j] = revArr[lenghtRevArr - k];
                lenghtRevArr++;
            }
            for (int z = 0; z < 2*k; z++)
            {
                arrBottom[z] = mainArr[z + k];
            }

            for (int r = 0; r < sumArr.Length ; r++)
            {
                sumArr[r] += arrTop[r] + arrBottom[r];
            }

            foreach (var item in sumArr)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
