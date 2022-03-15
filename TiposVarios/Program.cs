using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0x10;
            int x = 0xFF_2B_4A;
            int y = 0xFF2B4A;
            char a = '\u00A9';
            char b = '\u00B6';
            float f = 5.14f;
            double d = 4000.480;
            decimal m = 0.1452M;
            bool condition = false;
            Console.WriteLine($"Int K ={k}  Int Y = {y}  Int X = {x}  Char A = {a} Char B = {b}");
            Console.WriteLine($"Float f ={f} Double = {d} Decimal {m} Bool = {condition}");
            if (f < d)
            {
                condition = true;
                Console.WriteLine(condition);
            }

        }
    }
}
