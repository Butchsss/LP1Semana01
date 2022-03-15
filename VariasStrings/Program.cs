using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = " tab\t e um copyright \u03A9  ";
            string d = @"""Esta string esta entre aspas""  ";
            string c = @"Nao e' um codigo Unicode \1234, nao e' nova linha \n  ";
            Console.WriteLine($" S{s} D{d} C{c}");
        }
    }
}
