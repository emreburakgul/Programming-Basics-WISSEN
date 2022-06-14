using System;

namespace ArrayResize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Tsubasa", "Misaki" };

            Array.Resize(ref names, names.Length + 1);

            names[2] = "Hyuga";

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
