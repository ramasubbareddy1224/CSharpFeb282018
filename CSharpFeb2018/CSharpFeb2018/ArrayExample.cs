using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    public class ArrayExample
    {
        public void Display()
        {
            int a = 10;
            int b = 20;


            // option 1
            int[] intarray = { 10, 20, 30, 40 };

            // option 2
            int[] intarray2 = new int[4];
            intarray2[0] = 10;
            intarray2[1] = 20;
            intarray2[2] = 30;
            intarray2[3] = 40;

            // option 3
            int[] intarray3 = new int[4] { 10, 20, 30, 40 };

            string[] stringarray = { "rama", "krishna", "vishnu" };
            double[] decimalarray = { 10.3, 23.7, 12.11 };


            // Read one value from Array
            Console.WriteLine("read from intarray:" + intarray[2]);

            // Read all values from Array

            foreach (var item in intarray)
            {
                Console.WriteLine("read from intarray:" + item);
            }


        }
    }
}
