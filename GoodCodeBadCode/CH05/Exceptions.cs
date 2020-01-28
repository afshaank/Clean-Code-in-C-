using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace GoodCodeBadCode.CH05
{
    public class Exceptions
    {
        public static void CheckedArithmeticOperation()
        {

            decimal bankBalance = decimal.MaxValue;
            Debug.WriteLine($"Bank Balance: £{bankBalance}");
            Debug.WriteLine("Adding £1 to Bank Balance...");
            bankBalance += 1;
            Debug.WriteLine($"Bank Balance: £({bankBalance})");
        }

        public static void UncheckedArithemticOperation()
        {

            byte bankBalance = byte.MaxValue;
            Debug.WriteLine($"Bank Balance: £{bankBalance}");
            Debug.WriteLine("Adding £1 to Bank Balance...");
            unchecked
            {
                bankBalance += 1;
            }
            Debug.WriteLine($"Bank Balance: £({bankBalance})");
        }
    }
}
