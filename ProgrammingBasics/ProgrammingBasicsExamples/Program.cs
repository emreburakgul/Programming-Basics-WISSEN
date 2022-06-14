using System;

namespace ProgrammingBasicsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Birinci örnek
            // Ekrandan giriş yapılan sayının 5 katının 3'e bölümünden
            // kalan değeri ekrana yazdırın

            //Console.WriteLine("Lütfen bir sayı yazın");
            //string input = Console.ReadLine();

            //int number = int.Parse(input);

            //const int multiplier = 5;
            //const int divider = 3;
            //int result = (number * multiplier) % divider;

            //string message = $"{number} sayısının {multiplier} ile çarpımının {divider}'a bölümünden kalan {result} çıkar";
            //Console.WriteLine(message);
            #endregion

            #region İkinci örnek

            // Konsol ekranından giriş yapılan sayının 100'den büyük olup olmama durumuna göre
            // ekrana True veya False yazdıran programı geliştirin

            Console.WriteLine("Lütfen bir sayı yazınız:");
            string input = Console.ReadLine();

            int number = int.Parse(input);
            const int oneHundered = 100;
            Console.WriteLine($"{number} sayısı {oneHundered} değerinden büyük müdür? {number > oneHundered}");

            #endregion
        }
    }
}
