using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    class LogicalOp
    {
        static void Main()
        {
            int first = 10;
            int second = 20;

            bool thirdbool = true;

            bool output = (first == 10);  // true

            //  true && true = true
            // true && false = false
            // false && true = false
            // false && false = false

            bool sec1 = ((first == 10) && (second >= 20));  // if one statement is false then complete statement false

            bool sec2 = (first == 10) || (second > 30);  // true || false : true  // if one statement is true then complete statement true

            Console.WriteLine(sec1);
            Console.WriteLine(sec2);

            thirdbool = !thirdbool;

            Console.WriteLine(thirdbool);

            Console.Read();
        }
    }
}
