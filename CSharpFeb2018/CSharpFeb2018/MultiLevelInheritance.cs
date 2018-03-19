using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    public class MultiLevelInheritanceParent
    {
        public string Name { get; set; }

        public void DisplayMethod()
        {
            Console.WriteLine("This is display method");
        }
    }

    public class MultiLevelInheritanceChild1 : MultiLevelInheritanceParent
    {
        public void ChildMethod1()
        {
            DisplayMethod();
        }
    }

    public class MultiLevelInheritanceChild2 : MultiLevelInheritanceChild1
    {
        public void childMethod2()
        {
            ChildMethod1();
        }
    }
}
