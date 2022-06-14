using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // İşlemler
            // Bir operatör yardımıyla en az iki operandın işleme
            // dahil edilerek bir sonuç üretilmesi


            // Aritmetik işlemler
            // Aritmetik işlemlerin sonucu her zaman Sayı sonuç üretir
            // 4 işlemden bahsediyoruz
            // Toplama, Çıkarma, Çarpma, Bölme
            // Operator: +, -, *, /
            
            int total = 10 + 20;
            int grandTotal = total + 100;

            // Kalan bulma (mod alma) işlemini de aritmetik işlem
            // sayabiliriz
            // Operator: %
            int remaining = 10 % 3;


            // Karşılaştırma işlemleri
            // Karşılaştırma işlemlerinin sonucu her zaman boolean
            // sonuç üretir
            // Operator: >, <, >=, <=, ==, !=
            bool boolResult = 10 > 3;

            int number = 10;

            boolResult = number >= 4;


            // Mantıksal işlemler
            // İki veya daha fazla boolean değerin mantık operatörlerle
            // işleme sokulması
            // Operator: &&, ||

            boolResult = true && true;
            boolResult = false && true;
            boolResult = false && false;
            boolResult = false || true;

            boolResult = (10 > 3) && (2 == 2);


            // Expression
            boolResult = 10 > 5;

            // Statement
            Console.Write("Hello");



            // String birleştirme
            // String Concatenation
            string name = "Tsubasa";
            string surname = "Ozora";

            string fullName = name + " " + surname;
            fullName = string.Concat(name, " ", surname);

        }
    }
}
