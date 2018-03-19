using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    class MethodOverload
    {
        public void TestMethod()
        {
            Console.WriteLine("With empty parameters");
        }
        public void TestMethod(int a)
        {
            Console.WriteLine("with one parameter a:" + a);
        }
        public void TestMethod(int a, int b)
        {
            Console.WriteLine("with two parameters");
        }
        public void TestMethod(int a, string b)
        {
            Console.WriteLine("one integer and one string");
        }
        public void TestMethod(string a, int b)
        {
            Console.WriteLine("one string and one int");
        }
        public void TestMethod(string a, int b,int c)
        {
            Console.WriteLine("one string and one int");
        }
    }
}
