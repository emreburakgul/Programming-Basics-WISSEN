using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random sınıfından yeni bir nesne (instance/object) oluşturma
            Random random = new Random();
            var number = random.Next(1, 101);

            Console.WriteLine(number);  

            //for (int i = 0; i < 50; i++)
            //{
            //    Console.WriteLine(random.Next(0, 10));
            //}
        }
    }
}
