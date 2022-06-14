using System;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 100, 200, 300, 400, 500 };

            ReverseArraySelf(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //int[] reversedNumbers = ReverseArray(numbers);

            //for (int i = 0; i < reversedNumbers.Length; i++)
            //{
            //    Console.WriteLine(reversedNumbers[i]);
            //}
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Tek mi
        static bool IsOdd(int number)
        {
            return number % 2 != 0;
            //return number % 2 == 1;
            //return !(number % 2 == 0);
        }

        static int SquareOf(int number)
        {
            return number * number;
        }

        static int CubeOf(int number)
        {
            return SquareOf(number) * number;
        }

        static int[] ReverseArray(int[] array)
        {
            int[] reversed = new int[array.Length];

            int lastIndex = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                reversed[lastIndex - i] = array[i];
            }

            return reversed;
        }

        static void ReverseArraySelf(int[] array)
        {
            /*
             *          1.adım      2.adım      3.adım      4.adım      5.adım
             * 0 - 100  500                                             100
             * 1 - 200              400                     200
             * 2 - 300                          300                     
             * 3 - 400              200                     400
             * 4 - 500  100                                             500
             */

            int temp;
            int lastIndex = array.Length - 1;
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[lastIndex - i];
                array[lastIndex - i] = temp;
            }
        }

        static string Trim(string value)
        {
            return value.Trim();
        }
    }
}
