using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    class ConstructorEx
    {
        static ConstructorEx()
        {
            Console.WriteLine("This is static constructor");
        }       

        public ConstructorEx()
        {
            Console.WriteLine("This is constructor");
        }

        public ConstructorEx(int a)
        {
            Console.WriteLine("This is constructor with parameter a:"+a);
        }
        public ConstructorEx(int a,int b)
        {
            Console.WriteLine(string.Format("This is constructor with parameter a:{0} b:{1}", a, b));
        }

        public void PublicMethod()
        {
            Console.WriteLine("This is public method");
        }
    }
}
