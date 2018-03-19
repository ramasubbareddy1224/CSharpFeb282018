using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    public class SingleInheritanceParent
    {
        public string Name { get; set; }

        public void DisplayMethod()
        {
            Console.WriteLine("This is display method");
        }
    }

    public class SingleInheritanceChild : SingleInheritanceParent
    {
        public void ChildMethod()
        {
            DisplayMethod();
        }
    }
}
