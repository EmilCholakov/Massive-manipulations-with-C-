using System;

namespace upr05_04SieveOfErato
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool[] arr = new bool[num + 1];
            for (int i = 0; i <= num; i++)
            {
                arr[i] = true;
            }
            arr[0] = false; arr[1] = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    for (int a = 2; (a * i) <= num; a++)
                    {
                        arr[a * i] = false;
                    }
                }
            }
            for (int j = 2; j <= num; j++)
            {
                if (arr[j] == true)
                { Console.Write(j + " "); }
            }
            Console.WriteLine();
        }
    }
}