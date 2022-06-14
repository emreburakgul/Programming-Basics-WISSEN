using System;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region var keyword
            string text = "Bişeyler";
            int number = 10;

            // Variable kısaltması
            var name = "Tsubasa";
            var age = 18;
            var isPlayer = true;

            // var bir keyword'tür, kesinlikle bir VERİ TİPİ DEĞİLDİR!!!
            // var ile oluşturulmuş bir değişkene MUTLAKA İLK DEĞER atanmalıdır
            // değişkenin tipi atanan ilk değerin tipine eşittir
            // Çalışma prensibi kesinlikle JAVA SCRIPTTEKİ VAR'DAN FARKLI
            // MAKSADI: Hızlı kod yazmak ve kod okunurluğunu arttırmak

            // Sonradan farklı tipte değer atayamam
            //name = 100;

            // Böyle kullanamam
            //var input; 
            #endregion

            #region Built-in String Functions
            String Functions;
            var value = "   lorem   ipsum dolor     ";
            Console.WriteLine("Orijinal: \"{0}\"", value);

            var trimmed = value.Trim();
            Console.WriteLine("Trim: \"{0}\"", trimmed);

            var subStr = value.Substring(3, 5);
            Console.WriteLine("SubString: \"{0}\"", subStr);

            var index = value.IndexOf('o');
            Console.WriteLine("o Index: {0}", index);

            var lastIndex = value.LastIndexOf('o');
            Console.WriteLine("o LastIndex: {0}", lastIndex);

            var splitted = value.Split('m');
            for (int i = 0; i < splitted.Length; i++)
            {
                Console.WriteLine("Splitted[{0}]: \"{1}\"", i, splitted[i]);
            }
            #endregion

            var stringValue = "        Tsubasa        Ozora           Nankatsu      ";
            var trimmedValue = Trim(stringValue);
            //var trimmedValue = FullTrim(stringValue);
            Console.WriteLine("\"{0}\"", trimmedValue);
        }

        static string Trim(string value)
        {
            // "         Tsubasa   Ozora        "
            int indexOfFirstChar = value.Length;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] != ' ')
                {
                    indexOfFirstChar = i; // index 9 değerini buldum
                    break;
                }
            }

            int indexOfLastChar = 0;
            for (int i = value.Length - 1; i >= 0; i--)
            {
                if (value[i] != ' ')
                {
                    indexOfLastChar = i;
                    break;
                }
            }

            // "         Tsubasa   Ozora        "
            var trimmed = string.Empty; // "";
            for(int i = indexOfFirstChar; i <= indexOfLastChar ; i++)
            {
                trimmed = trimmed + value[i];
            }

            return trimmed;
        }

        static string FullTrim(string value)
        {
            // "        Tsubasa           Ozora        Nankatsu      "
            // "Tsubasa Ozora Nankatsu"

            var indexOfFirstChar = value.Length;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] != ' ')
                {
                    indexOfFirstChar = i; // index 9 değerini buldum
                    break;
                }
            }

            var indexOfLastChar = 0;
            for (int i = value.Length - 1; i >= 0; i--)
            {
                if (value[i] != ' ')
                {
                    indexOfLastChar = i;
                    break;
                }
            }

            var fullTrimmed = string.Empty;
            var spaceDetected = false;

            // "        Tsubasa           Ozora        Nankatsu      "
            for (var i = indexOfFirstChar; i <= indexOfLastChar; i++)
            {
                if (value[i] != ' ')
                {
                    if (spaceDetected)
                    {
                        fullTrimmed += ' ';
                        spaceDetected = false;
                    }

                    fullTrimmed += value[i];
                }
                else
                {
                    spaceDetected = true;
                }
            }

            return fullTrimmed;
        }
    }
}
