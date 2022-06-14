using System;

namespace ValidatedInput
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            string input;
            int number;

            int tryCount = 0;
            const int maxTryCount = 3;

            do
            {
                if (tryCount > 0)
                {
                    Console.Write("Hatalı bir giriş yaptınız! ");
                }
                Console.WriteLine("Bir sayı giriniz: ");
                input = Console.ReadLine();

                result = int.TryParse(input, out number);
                tryCount++;
            } while (!result && tryCount < maxTryCount) ;

            if (result)
            {
                Console.WriteLine("Tebrikler");
            }
            else
            {
                Console.WriteLine("Deneme hakkınız kalmadı");
            }

            //if (result == false)
            //if(!result)
            //if (result)
            //{
            //    Console.WriteLine($"Sayı dönüşümü başarılı: {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış formatta sayı girişi");
            //}
        }
    }
}
