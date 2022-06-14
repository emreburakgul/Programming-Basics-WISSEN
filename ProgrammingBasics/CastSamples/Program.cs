using System;

namespace CastSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            double doubleNumber = 40147483647;
            int intNumber = (int)doubleNumber;

            //long longNumber = 5147483647;
            //int intNumber = (int)longNumber;

            Console.WriteLine("Int değişkenin değeri {0}", intNumber);
        }
    }
}
