using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    public class HierarchicalInheritanceParent
    {
        public string Name { get; set; }

        public void DisplayMethod()
        {
            Console.WriteLine("This is display method");
        }
    }

    public  class HierarchicalInheritanceChild1 : HierarchicalInheritanceParent
    {
        public void ChildMethod1()
        {
            DisplayMethod();
        }
    }

    public class HierarchicalInheritanceChild2 : HierarchicalInheritanceParent
    {
        public void ChildMethod2()
        {
            DisplayMethod();
        }
    }
}
