using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    class MainEntry
    {
        static void Main()
        {
            //AccessSpecifier obj = new AccessSpecifier();
            //obj.PublicMethod();
            //obj.InternalMethod();

            int first = 10;
            int second = 20;

            //ConstructorEx obj = new ConstructorEx();
            //obj.PublicMethod();

            //ConstructorEx obj = new ConstructorEx();
            //ConstructorEx obj1 = new ConstructorEx();

            //MethodOverload Obj = new MethodOverload();
            //Obj.TestMethod();
            //Obj.TestMethod(first);

            //StudentTest  = new StudentTest();
            //Obj.Marks = 80;
            //Console.WriteLine(Obj.GetStudentMarks());

            //SingleInheritanceChild Obj = new SingleInheritanceChild();
            //Obj.ChildMethod();

            // AbstractClassExample obj = new AbstractClassExample();

            //AbstractDerivedClass Obj = new AbstractDerivedClass();
            //Obj.AbstractMethod();

            InterfaceDeriveClass Obj = new InterfaceDeriveClass();
            Obj.Method1();


            Console.Read();
        }
    }
}
