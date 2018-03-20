using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    public abstract class AbstractClassExample
    {
        public void NormalMethod()
        {
            Console.WriteLine("This is normal method");
        }

        public abstract void AbstractMethod();
        public abstract void Abstract2Method();

        public virtual void VirtualMethod()
        {
            Console.WriteLine("This is virtual method");
        }
    }

    public class AbstractDerivedClass : AbstractClassExample
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("This is abstract method implementation");
            NormalMethod();
        }
        public override void Abstract2Method()
        {
            Console.WriteLine("This is abstract2 method implementation");

        }
        public override void VirtualMethod()
        {
            Console.WriteLine("This is virtual override method");
        }

    }
}
