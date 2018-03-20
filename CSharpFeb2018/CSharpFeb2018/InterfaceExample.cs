using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    public interface InterfaceExample
    {
        void Method1();
        void Method2();
    }

    public interface Interface2Example
    {
        void Method3();
    }

    public class InterfaceDeriveClass : InterfaceExample, Interface2Example
    {
        public void Method1()
        {
            Console.WriteLine("This is method1");
        }
        public void Method2()
        {
            Console.WriteLine("This is method2");
        }
        public void Method3()
        {
            Console.WriteLine("This is method3");
        }
    }
}
