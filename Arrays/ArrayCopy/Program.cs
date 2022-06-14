using System;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 10, 20, 30, 40, 50 };
            //int[] copy = numbers;
            int[] copy = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                copy[i] = numbers[i];
            }

            copy[0] = 1000;

            Console.WriteLine("numbers dizinin elemanları:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("{0}. eleman: {1}", i, numbers[i]);
            }

            Console.WriteLine("copy dizinin elemanları:");
            for (int i = 0; i < copy.Length; i++)
            {
                Console.WriteLine("{0}. eleman: {1}", i, copy[i]);
            }
        }
    }
}
