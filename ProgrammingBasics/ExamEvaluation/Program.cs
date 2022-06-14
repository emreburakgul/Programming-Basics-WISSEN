using System;

namespace ExamEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ekrandan yapılan sayısal not girişi için
             * 100 - 85 aralığı nota Pekiyi (5)
             * 84 - 70 aralığı için İyi (4)
             * 69 - 55 aralığı için Orta (3)
             * 54 - 45 aralığı için Geçer (2)
             * 44 ve aşağısı değerler için Kaldı (1)
             * yazdıran programı geliştirin
             */

            Console.WriteLine("Lütfen not değerini yazın:");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number < 0 || number > 100)
            {
                Console.WriteLine("Geçerli bir not yazmadınız");
            }
            else
            {
                const int minPekiyi = 85;

                if (number >= minPekiyi)
                {
                    Console.WriteLine("Pekiyi (5)");
                }
                else if (number >= 70)
                {
                    Console.WriteLine("İyi (4)");
                }
                else if (number >= 55)
                {
                    Console.WriteLine("Orta (3)");
                }
                else if (number >= 45)
                {
                    Console.WriteLine("Geçer (2)");
                }
                else
                {
                    Console.WriteLine("Kaldı (1)");
                }
            }

            //else if (number < 0 || number > 100)
            //{
            //    Console.WriteLine("Lütfen geçerli (0-100 arasında) bir not giriniz");
            //}
        }
    }
}
