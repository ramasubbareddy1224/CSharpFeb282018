using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    class ArthimeticAssignmentOp
    {
        static void Main()
        {
            int first = 20;

            Console.WriteLine("before assign:" + first);  // 20

            first = first + 20;
            first += 20;


            first = first - 20;
            first -= 20;

            first = first * 20;
            first *= 20;


            first = first / 20;
            first /= 20;

            Console.WriteLine("after assign:" + first);  // 40

            Console.Read();
        }
    }
}
