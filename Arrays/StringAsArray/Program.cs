using System;

namespace StringAsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // String tip aslında bir dizidir!
            // string tipini (birebir olmasa da) char[] dizisi olarak düşünebilirsiniz

            string name = "Tsubasa Ozora";
            //char[] name = new { 'T', 's', 'u', 'b', 'a'...... };
            char character;

            for (int i = 0; i < name.Length; i++)
            {
                character = name[i];
                Console.WriteLine(character);
            }

            // String tipindeki bir değerin tek tek index'inci elemanları okunabilir
            // ancak DEĞİŞTİRİLEMEZ!!
            // Buna string'in IMMUTABLE özelliği deniyor
            //name[0] = 'M';
            //name[0] = "M";

            char[] nameAsArray = name.ToCharArray();
            nameAsArray[0] = 'M';

            // Console'un Write/WriteLine metodu char[] dizisini sanki string tipinde bir
            // değişkenmiş gibi ekrana yazdırabiliyor
            Console.WriteLine(nameAsArray);

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(numbers);

            string value = "";
            value = string.Empty;

            // Empty string ve NULL değer KESİNLİKLE FARKLI MEVZULAR!!

            string val1 = "";
            string val2 = "     ";
            string val3 = null;
            string val4;
        }
    }
}
