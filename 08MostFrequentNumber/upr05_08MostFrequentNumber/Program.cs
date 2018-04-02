using System;
using System.Linq;

namespace upr05_08MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] counters = new int[arr.Length];
            int counterMax = 0;
            int numberMax = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counters[i]++;
                        if (counters[i] > counterMax)
                        {
                            counterMax = counters[i];
                            numberMax = arr[i];
                        }
                    }
                }
            }
            Console.WriteLine(numberMax);
        }
    }
}
