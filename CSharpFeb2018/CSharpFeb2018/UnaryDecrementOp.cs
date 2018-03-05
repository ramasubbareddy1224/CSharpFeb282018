using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    class UnaryDecrementOp
    {
        static void Main()
        {
            // Pre-decrement

            int count = 5;
            Console.WriteLine("before count value:" + count);

            int afterdecrement = --count;

            Console.WriteLine("afterdecrement value:" + afterdecrement);
            Console.WriteLine("after postcount value:" + count);


            // Post-decrement

            int postcount = 5;
            Console.WriteLine("before postcount value:" + postcount);

            int afterpostdecrement = postcount--;

            Console.WriteLine("afterpostdecrement value:" + afterpostdecrement);
            Console.WriteLine("after postcount value:" + postcount);

            Console.Read();
        }
    }
}
