using System;

namespace _08AssignStringContainingQuotations
{
    class AssignStringContainingQuotations
    {
        static void Main()
        {
            string variable1 = @"The ""use"" of quotations causes difficulties.";
            string variable2 = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine("Variable1: {0}", variable1);
            Console.WriteLine("Variable2: {0}", variable2);
        }
    }
}
