using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    public class GenericList
    {
        public void Display()
        {
            List<int> intlist = new List<int>();
            intlist.Add(10);
            intlist.Add(20);
            intlist.Add(30);
            intlist.Add(40);
            intlist.Add(50);
            intlist.Add(60);

            foreach (var item in intlist)
            {
                Console.WriteLine("read from intarray:" + item);
            }
        }
    }
}
