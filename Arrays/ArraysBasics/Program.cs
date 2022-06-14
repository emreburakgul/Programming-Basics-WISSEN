using System;

namespace ArraysBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diziler
            // Aynı tipte birden fazla elemandan oluşan değerler topluluğu

            // 3 elemanlı, ve tüm elemanların varsayılan değerinde olduğu dizi
            int[] numbers = new int[3];

            // Dizinin boyutunu okuma
            int arrayLength = numbers.Length;

            // Dizinin ilk elemanını okuma
            int firstItem = numbers[0];

            // Dizinin son elemanını okuma
            int lastItem = numbers[numbers.Length - 1];

            numbers[0] = 10;
            numbers[1] = 20;

            // Başta biz bu dizinin boyutunu 3 elemanlı olarak belirledik
            // DİKKAT! Index'ler hep 0'dan başlar
            // IndexOutOfRangeException
            numbers[3] = 100; // Hata
            int thirdIndexItem = numbers[3]; // Hata


            // Alternatif dizi tanımlama
            string[] names = new string[] { "Tsubasa", "Misaki", "Hyuga" };
            int[] nums = new int[] { 1, 2, 3, 4, 5 };
        }
    }
}
