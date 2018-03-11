using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    class AccessSpecifier
    {
        public void PublicMethod()
        {
            Console.WriteLine("This is public method");
        }
        private void PrivateMethod()
        {
            Console.WriteLine("This is private method");
        }
        protected void ProtectedMethod()
        {
            Console.WriteLine("This is private method");
        }
        internal void InternalMethod()
        {
            Console.WriteLine("This is private method");
        }
    }
}
