using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
   public class StringBuilderExample
    {
        public void Display()
        {
            string name = "pragim";
            name = name + "technology";
            
            StringBuilder SBObj = new StringBuilder();
            SBObj.Append("pragim");
            SBObj.Append("technology");

            Console.WriteLine("using string:"+name);
            Console.WriteLine("using string builder:"+SBObj.ToString());
        }
    }
}
