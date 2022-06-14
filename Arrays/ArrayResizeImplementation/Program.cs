using System;

namespace ArrayResizeImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[3]; // array = 0x1234
            array[0] = "Tsubasa";
            array[1] = "Misaki";
            array[2] = "Hyuga";

            // Bu diziyi 4 elemanlı olarak yeniden boyutlandırmak istiyoruz
            // Ancak mevcut elemanların yok olmaması gerekiyor

            //string[] temp = new string[array.Length];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    temp[i] = array[i];
            //}

            string[] temp = array;
            // array => 0x1234
            // temp => 0x1234

            array = new string[array.Length + 1]; // => 0x5678
            // array => 0x5678
            // temp => 0x1234

            for(int i = 0; i < temp.Length; i++)
            {
                array[i] = temp[i];
            }

            array[array.Length - 1] = "Wakabayashi";

            int index = 0;
            while(index < array.Length)
            {
                Console.WriteLine(array[index]);

                index++;
            }
        }
    }
}
