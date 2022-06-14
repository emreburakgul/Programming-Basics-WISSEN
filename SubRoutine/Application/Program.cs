using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
            var selection = ReadInteger();
            DisplaySubMenu(selection);

        }

        static void DisplaySubMenu(int selection)
        {
            if (selection == 1)
            {

            }
        }

        static int ReadInteger()
        {
            string input;
            int number;
            bool parseResult;
            do
            {
                Console.WriteLine("Lütfen bir sayı yazınız");
                input = Console.ReadLine();
                parseResult = int.TryParse(input, out number);

                if (!parseResult)
                {
                    Console.Write("Format hatası!! ");
                }

            } while (!parseResult);

            return number;
        }

        static void DisplayMenu()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Lütfen size uygun bir seçeneğin numarasını girin");
            Console.WriteLine("Seçenek 1");
            Console.WriteLine("Seçenek 2");
        }
    }
}
