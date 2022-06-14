using System;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            // Decision Making / Decision Control
            // Karar Kontrol Yapıları
            // If, If-Else, Switch-Case

            // IF
            // Bir veya birden fazla satırın çalışmasını bir (veya bileşik)
            // bir koşula bağlamaktır

            Console.WriteLine("Lütfen isminizi yazın: ");
            string input = Console.ReadLine();

            // C# => Strongly Typed
            // JavaScript => Loosely Typed

            bool result = input.Length > 5;
            if (result)
            {
                Console.WriteLine("İsminiz pek uzunmuş");
                Console.WriteLine("Lütfen isminizi değiştirin");
            }
            else
            {
                Console.WriteLine("İsminiz normal");
            }

            //if (input.Length > 5 && DateTime.Today.Year == 2022)
            //{

            //}

            if (input.Length > 5)
                Console.WriteLine("İsminiz çok uzun");

            if (input.Length > 5)
            {
                Console.WriteLine("İsminiz çok uzun");
            }
            else if (input.Length < 2)
            {
                Console.WriteLine("İsminiz yok gibi bir şey");
            }
            else
            {
                Console.WriteLine("Normal bir isim");
            }


        }
    }
}
