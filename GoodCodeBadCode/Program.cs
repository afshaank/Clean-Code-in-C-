using GoodCodeBadCode.CH05;
using GoodCodeBadCode.RegEx;
using System;

namespace GoodCodeBadCode
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValidEmail = args[0].IsValidEmail();
            Console.WriteLine("Hello World!");

            Chapter5();
        }

        private static void Chapter5()
        {
            Exceptions.UncheckedArithemticOperation();
            Exceptions.CheckedArithmeticOperation();
        }
    }
}
