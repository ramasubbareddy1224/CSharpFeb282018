using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    class ClassMethod
    {

        // method without parameters
        public void TestMethod()
        {
            Console.WriteLine("This is TestMethod");
        }

        // method with one integer parameters
        public void TestMethod2(int a)
        {
            Console.WriteLine("This is TestMethod2 with parameter a:" + a);
        }

        // method with two integer parameters
        public void TestMethod3(int a, int b)
        {
            Console.WriteLine(string.Format("This is TestMethod3 with parameter a:{0} b:{1}", a, b));
        }

        // method with  integer and string parameters
        public void TestMethod4(int a, string b)
        {
            Console.WriteLine(string.Format("This is TestMethod4 with parameter a:{0} b:{1}", a, b));
        }

        // method with integer return type
        public int TestMethod5()
        {
            int val = 10;

            return val;
        }

        // method with integer return type and parameter
        public int TestMethod6(int a)
        {
            return a;
        }

        static void Main()
        {
            int value1 = 10;
            int value2 = 20;
            string sval = "pragim";
            ClassMethod obj = new ClassMethod();
            obj.TestMethod();
            obj.TestMethod2(value1);
            obj.TestMethod3(value1, value2);
            obj.TestMethod4(value1, sval);

            int output = obj.TestMethod5();
            int output2 = obj.TestMethod6(value1);

            Console.WriteLine("output is:" + output);
            Console.WriteLine("output2 is:" + output2);

            Console.Read();
        }
    }
}
