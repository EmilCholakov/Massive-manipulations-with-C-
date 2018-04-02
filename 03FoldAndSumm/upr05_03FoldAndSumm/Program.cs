using System;
using System.Linq;

namespace upr05_03FoldAndSumm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            int[] upperArr = new int[numbers.Length / 2];
            int[] lowerArr = new int[numbers.Length / 2];

            for (int i = 0; i < 2*k; i++)
            {
                lowerArr[i] = numbers[k + i];
            }
            for (int i = 0; i < k; i++)
            {
                upperArr[i] = numbers[k - 1 - i];
                upperArr[k + i] = numbers[4 * k - 1 - i];
            }

            int[] sum = new int[2 * k];
            for (int i = 0; i < 2*k; i++)
            {
                sum[i] = upperArr[i] + lowerArr[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
