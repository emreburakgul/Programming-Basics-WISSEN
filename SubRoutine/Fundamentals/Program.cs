using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tekrar eden işlemleri tekrar kullanılabilir tek satırlık
            // komutlara (statement) dönüştürmek için fonksiyonlar (metotlar)
            // kullanılır

            WriteName(); // Fonksiyonu bu şekilde çağırıyorum
            WriteName();
            WriteName(); // Fonksiyonların güzelliği tekrar tekrar çağırılabilir olması

            string name = GetName();
            string surname = GetSurname();

            //string value = WriteName(); => void fonksiyonu bu şekilde çağıramam

            GetName(); // dönüş tipi olan bir fonksiyonu bu şekilde çağırabilirim
            // ama anlamlı olmayabilir

            Console.WriteLine($"{name} {surname}");
            Console.WriteLine($"{GetName()} {GetSurname()}");

            int sum = GetSum(10, 20);
            Console.WriteLine("10 ile 20'nin toplamı: {0}", sum);

            int number1 = 10;
            // Farklı bir fonksiyonda tanımlanmış
            // değişken veya parametre isimlerini başka bir fonksiyonda
            // tanımlayabilirim/kullanabilirim

            int sayi01 = 40;
            int sayi02 = 100;
            int toplam = GetSum(sayi01, sayi02);
            Console.WriteLine($"{sayi01} ile {sayi02} sayılarının toplamı: {toplam}");


            int number = 100;
            // Fonksiyona bir değişkeni argüman (parametre) değeri olarak gönderirken
            // o değişkenin RAM'de STACK'te tutulan değerinin bir kopyası gönderilir.
            // Haliyle; parametre olarak kullanılan değişken eğer DEĞER TİPLİ (struct)
            // ise fonksiyon içerisinde o değere yapılan bir değişiklik dış dünyaya
            // yansımaz

            ChangeNumber(number);
            Console.WriteLine("sayım değişmedi{0} ", number);

            int[] numberArray = new int[] { 10, 20, 30 };
            //int[] numbers = numberArray;
            //numbers[0] = 0;
            ChangeArrayItem(numberArray);
            

            // numberArray => 0x1234
            
            //int[] numbers = numberArray; // numbers <= 0x1234
            //numbers = new int[0]; // numbers <= 0x5678
            ChangeArray(numberArray);

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }
        }

        // => Aslında önce Access Modifier (erişim belirleyici)
        // => Console ortamında devam ettiğimiz için 'static' keyword'ünü ezbere ekliyorum
        // Önce dönüş tipi
        // Sonra fonksiyon ismi (PascalCase)
        // Sonra parametre kısmı { parantezler }
        static void WriteName()
        {
            Console.WriteLine("Tsubasa");
        }

        static string GetName()
        {
            return "Tsubasa";
        }

        static string GetSurname()
        {
            string surname = "Ozora";
            return surname;

            int number = 10; // Bu satır çalıştırılmayacak
        }

        // Parametreler
        static int GetSum(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
            // Ya da
            // return number1 + number2;
        }

        static void ChangeNumber(int number)
        {
            number = 0;
        }

        static void ChangeArrayItem(int[] numbers)
        {
            numbers[0] = 0;
        }

        static void ChangeArray(int[] numbers)
        {
            numbers = new int[0];
        }
    }
}
