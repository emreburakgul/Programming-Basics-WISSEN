using System;

namespace ArraysSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilecek 3 adet ismi bir dizi üzerinde biriktirin
            // Döngü kullanmaya çalışın

            string[] names = new string[3]; // 3 elemanlı dizi oluşturdum
            // dizinin şu an tüm elemanları 'null' değerinde

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("{0}. ismi yazın", i + 1);
                names[i] = Console.ReadLine();
            }

            // Alternatif; while döngüsü ile
            int index = 0;
            while (index < names.Length)
            {
                Console.WriteLine("{0}. ismi yazın", index + 1);
                names[index] = Console.ReadLine();

                index += 1;
            }

            int[] numbers = new int[3];
            string input;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Bir sayı yazın");
                input = Console.ReadLine();
                numbers[i] = int.Parse(input);
            }
        }
    }
}
