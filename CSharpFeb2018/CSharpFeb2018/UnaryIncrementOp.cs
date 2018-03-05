using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    class UnaryIncrementOp
    {
        static void Main()
        {
            // Pre-increment

            int count = 5;
            Console.WriteLine("before count value:" + count);

            int afterincrement = ++count;

            Console.WriteLine("afterincrement value:" + afterincrement);
            Console.WriteLine("after postcount value:" + count);


            // Post-increment

            int postcount = 5;
            Console.WriteLine("before postcount value:" + postcount);

            int afterpostincrement = postcount++;

            Console.WriteLine("afterpostincrement value:" + afterpostincrement);
            Console.WriteLine("after postcount value:" + postcount);

            Console.Read();
        }
    }
}
