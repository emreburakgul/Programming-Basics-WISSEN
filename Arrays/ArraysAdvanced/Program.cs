using System;

namespace ArraysAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 elemanlı bir dizi oluşturabilirim
            int[] numbers = new int[0];
            //numbers[0] = 10; // IndexOutOfRangeException

            // Daha sonra aynı dizi değişkenini başka bir diziyle
            // değiştirebilirim
            numbers = new int[5];

            // Dizi elemanlarına tek tek atama yapabilirim
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            // Aynı dizi değişkenine yeni bir dizi INSTANCE'ı oluşturduğumda
            // eski dizinin yerinde yeller esiyor
            // Diğer bir değişle; eski dizinin elemanları yok oldu
            numbers = new int[3];

            // firstItem değişkeninin değeri 0 olacak. Çünkü üstteki satırda tamamen YENİ
            // bir dizi oluşturdum, ve dizinin 3 elemanı da Int32 tipinin varsayılan değeri
            // olan 0 değerini aldı
            int firstItem = numbers[0];

            string[] names = new string[2];
            // names[0] ve names[1] konumunda yer alan elemanların değeri şu an null
            // Çünkü string tipinin varsayılan değeri null
            // Daha geniş ifadeyle; Referans tipli değişkenlerin varsayılan değeri null

            numbers = new int[5];
            numbers[0] = 100;
            numbers[1] = 200;
            numbers[2] = 300;
            numbers[3] = 400;
            numbers[4] = 500;

            // Değer tipli
            //int number01 = 10;
            //int number02 = number01;
            //number01 = 20;
            // number01 20 oldu, number02 10 olarak kalır

            int[] numbersCopy = numbers;
            numbersCopy[4] = 1000;

            Console.WriteLine(numbers[4]); 
            // Copy dizinin son elemanını değiştirdim ancak
            // numbers dizisinin de elemanı değişti. NEDEN?

            
        }
    }
}
