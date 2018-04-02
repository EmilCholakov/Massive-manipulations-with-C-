using System;
using System.Linq;

namespace upr05_05CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] wordOne = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] wordTwo = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            bool isFirst = false;

            for (int i = 0; i < Math.Min(wordOne.Length, wordTwo.Length); i++)
            {
                if (wordOne[i] < wordTwo[i])
                {
                    isFirst = true;
                    break;
                }
                else if (wordTwo[i] > wordOne[i])
                {
                    isFirst = false;
                    break;
                }
                if (i == Math.Min(wordOne.Length, wordTwo.Length) - 1)
                {
                    if (wordOne.Length < wordTwo.Length)
                    {
                        isFirst = true;
                    }
                    else
                    {
                        isFirst = false;
                    }
                }
            }
            if (isFirst)
            {
                Console.WriteLine(string.Join("", wordOne));
                Console.WriteLine(string.Join("", wordTwo));
            }
            else
            {
                Console.WriteLine(string.Join("", wordTwo));
                Console.WriteLine(string.Join("", wordOne));
            }
        }
    }
}
