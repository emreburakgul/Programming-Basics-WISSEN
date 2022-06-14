using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aslında tip dönüşümü dediğimiz iki tane işlem var
            // 1. String tipinden diğer primitive tiplere dönüşüm (Parse)
            // 2. Herhangi bir şeyi .ToString() metodunu çağırarak stringleştirmek


            // method overload
            // Aynı metodun farklı parametrelerle yazılmış halleri

            //Console.Write("\n\r");
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            string input = Console.ReadLine();


            //string message = string.Format("Giriş yapılan sayı: {0}", input);
            //Console.WriteLine(message);

            // String Interpolation
            //string message = $"Giriş yapılan sayı: {input}";

            //Console.WriteLine($"Giriş yapılan sayı: {input}");

            // Parse metodu genel bir özetle bir string değeri
            // XX sayısal tipine çevirir
            // XX => int, long, byte, vs..
            int number = int.Parse(input);
            int result = number * number;

            //number = Convert.ToInt32(input);

            //double doubleNum = 10;
            //int intNum = (int)doubleNum;

            Console.WriteLine("Giriş yapılan sayı: {0}\n\rSayının karesi: {1}", input, result);




            //int num = 100;
            //char charVal = (char)num; // Explicitno
        }
    }
}
