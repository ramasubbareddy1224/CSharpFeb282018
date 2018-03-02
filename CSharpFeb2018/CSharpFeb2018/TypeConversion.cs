using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    class TypeConversion
    {
        static void Main()
        {
            // ------------- Boxing --------------- // 

            int num = 10;  // value type
            double score = 83.2;

            string stringtext = num.ToString(); // Boxing : value type - ref type
            string stringdouble = score.ToString();

            Console.WriteLine(stringtext);
            Console.WriteLine(stringdouble);

            // -------------- ------------------- //

            // ----------- UnBoxing -------------- //
            string s = "100";
            string s2 = "46.3";
            string s3 = "true";
            string s4 = "a";

            int intvalue = Convert.ToInt32(s);
            double dvalue = Convert.ToDouble(s2);
            bool bvalue = Convert.ToBoolean(s3);
            char cval = Convert.ToChar(s4);

            Console.WriteLine(intvalue);
            Console.WriteLine(dvalue);
            Console.WriteLine(bvalue);
            Console.WriteLine(cval);

            Console.Read();

        }
    }
}
