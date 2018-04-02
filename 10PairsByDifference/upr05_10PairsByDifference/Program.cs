using System;
using System.Linq;

namespace upr05_10PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (Math.Abs(arr[i] - arr[j + 1]) == difference)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter - 1);
        }
    }
}
