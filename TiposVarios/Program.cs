using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 3;
            int k = 0x10;
            //uint l = 0x10U;
            int x = 0xFF_2B_4A;
            int y = 0xFF2B4A;
            char a = '\u00A9';
            char b = '\u00B6';
            Console.WriteLine(k);
            Console.WriteLine(y);
            Console.WriteLine(x);
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
