using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    public class ArrayListExample
    {
        public void Display()
        {
            ArrayList List = new ArrayList();
            List.Add(10);
            List.Add(20);
            List.Add("pragim");
            List.Add(23.24);

            foreach (var item in List)
            {
                Console.WriteLine("array list item:" + item);
            }

        }
    }
}
