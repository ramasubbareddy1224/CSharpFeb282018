using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    class Student
    {
        public void Test()
        {
            Console.WriteLine("This is sample test method");
        }

        public void Test2()
        {
            Console.WriteLine("This is sample test2 method");
        }

        static void Main()
        {
            Student obj = new Student();
            obj.Test();
            obj.Test2();


            Console.Read();

        }
    }
}
