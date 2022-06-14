using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Döngüler
            // Bir veya birden fazla işlemi tekrar tekrar yapmak için kullanıyoruz

            //string input = Console.ReadLine();

            //while (input.Length > 5)
            //{
            //    Console.WriteLine("İsminiz pek uzun");
            //}


            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter = counter + 1;
            }

            for (int index = 0; index < 10; index = index + 1)
            {
                //
                //
                //
            }

            for (; true;)
            {

            }


            do
            {

                counter++;
                //counter += 1;
            } while (counter < 10);
        }
    }
}
