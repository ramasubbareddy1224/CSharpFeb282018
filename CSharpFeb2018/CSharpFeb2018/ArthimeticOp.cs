using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    class ArthimeticOp
    {
        static void Main()
        {
            int fistnum = 20;
            int secondnum = 30;

            int addition = fistnum + secondnum;
            int subtraction = fistnum - secondnum;
            int mul = fistnum * secondnum;
            int division = fistnum / secondnum;

            Console.WriteLine("addition is :" + addition);
            Console.WriteLine("subtraction is :" + subtraction);
            Console.WriteLine("mul is :" + mul);
            Console.WriteLine("division is :" + division);

            Console.Read();
        }
    }
}
