using System;
using System.Text;

namespace _05AssignCharVarWithASymbolInUnicode
{
    class Program
    {
        static void Main()
        {
            char variable  = '\u0048';
            Console.WriteLine("The variable in unicode is {0} and has a simbol {1}", (int)variable, variable);
        }
    }
}
