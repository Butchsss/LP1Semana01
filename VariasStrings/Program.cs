using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 45;
            int i = 55;
            string s = " tab\t e um copyright \u03A9  ";
            string d = @"""Esta string esta entre aspas""  ";
            string c = @"Nao e' um codigo Unicode \1234, nao e' nova linha \n  ";
            Console.WriteLine($" S{s} D{d} C{c}");
            string a = "ola + " + 3;
            string b = " = ola + 3";
            string e = "tudo bem?" + b;
            string f = String.Format("Arg {0} e {1}", x, i);
            Console.WriteLine($"{a}{b}{e}");
            Console.WriteLine(f);
            Console.WriteLine($"valor de x = {x}");
            Console.WriteLine($"Valor de  {i} + {x} = { i + x }");
            double xx = 0.12345;
            int ii = 18;
            Console.WriteLine($"Numero real={xx:f2} Percentagem = {ii:p1}");
            Console.WriteLine($"Moeda = {ii:c}  Hexadecimal = {ii:x}");


        }
    }
}
