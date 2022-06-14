using System;

namespace DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yorum Satırı

            // camelCase (değişken, parametre, local sabit tanımı)
            // PascalCase (Sınıf tanımı, global sabit tanımı)
            // _digerCamelCase (private field)
            // UPPERCASE
            // lowercase
            // snake_case
            // kebab-case (css)
            // s_firstName (Hungary Case)

            // Kesin değerli nümerik tipler

            // Identifier
            int intNumber; // 32bit
            intNumber = 10;

            byte byteNumber; // 8bit

            short shortNumber; // 16bit

            long longNumber; // 64bit

            decimal decimalNumber; // 128bit

            decimalNumber = 100;

            decimalNumber = 10.5m; // m => money

            char charValue = 'a';
            charValue = 'A';

            // Metinsel veri tipi
            string name = "Tsubasa";

            // Escape char \
            string sentence = "Ümit \"bir soru\" sormuştu";
            string value = "Emre \t Aldemir"; // Tab karakteri ekledim
            value = "Emre \n Aldemir";
            value = "Emre \n\r Aldemir";
            Console.WriteLine(value);
            /*
             * \n => New Line
             * \r => Carriage Return
             */

            // string tipi değişkenler null değeri alabilir
            string something = null;

            // Yaklaşık nümerik tipler
            double doubleNumber = 10.5; // 64bitlik kayan noktalı sayı
            doubleNumber = 20.5d;

            float floatNumber = 10.5f; // 32bitlik kayan noktalı sayı

            // Implicit Cast (Conversion)
            doubleNumber = floatNumber;

            // Explicit Cast (Conversion)
            floatNumber = (float)doubleNumber;

            byteNumber = 10;
            shortNumber = byteNumber;


            string string00;
            string string01 = ""; // Empty string
            string string02 = "    "; // White space string
            string string03 = null; // NULL
            //string string04 = string00;

            byte? nullableByte;
            nullableByte = null;

            bool isTrue = true;
            Boolean boolValue = false;

            // Özetle
            // Şu ana kadar yazdığımız tüm tipler Primitive Types olarak adlandırılır
            // İçlerinden yalnızca string olan "referans" tipliydi (Reference type)
            // Diğer veri tipleri "değer" tipliydi (Value type)


            // CLI (CTS => Common Type Specification)
            int intNumber00 = 10;
            Int32 intNumber11 = 10;
            // VB => Integer

            // Magic values
            intNumber00 = 100;

            // Magic value değil
            intNumber00 = int.MaxValue;


            // Sabit tanımı yaparak magic value önüne geçilebilir
            // Sabit değer tanımı const ile yapılır, sonrasında
            // veri tipi yazılır
            // Sabit değerlerin "adı üzerinde" değeri değiştirilemez
            const int waterBoilPoint = 100;
            intNumber00 = waterBoilPoint;
            //waterBoilPoint = 1000;

            const decimal minPrice = 1;
            const decimal maxPrice = 10000;

            const string projectVersion = "1.2.0";

            // Diğer veri tipleri
            object objectValue;
            objectValue = 10; // Boxing
            //objectValue = "Tsubasa";

            // Explicit cast
            // Unboxing
            int objectNumValue = (int)objectValue;

            int result = 100 * objectNumValue;
            result = 100 * (int)objectValue;

            string unboxedString = (string)objectValue;

            // DateTime
            DateTime today = DateTime.UtcNow;
            DateTime yesterday = DateTime.Today.AddDays(-1);
            yesterday = DateTime.Parse("12.01.2022");

            // Guid
            Guid id = Guid.NewGuid();
            id = Guid.Parse("61915c58-2b52-4850-b89e-2583633a91ac");

            // Literal assignment
            // Bir değişkenin değerini doğrudan atayabilme
            // Doğrudan: Başka bir metoda, fonksiyona, yardımcı bir
            // komuta ihtiyaç duymadan
            int number001 = 10;
            string string001 = "Emre";
        }
    }
}
