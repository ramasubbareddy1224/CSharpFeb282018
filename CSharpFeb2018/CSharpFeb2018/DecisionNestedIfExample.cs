using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    class DecisionNestedIfExample
    {
        static void Main()
        {
            bool allowed = true;
            bool nestedallowed = false;
           // int age = 30;
            if (allowed == true)
            {
                Console.WriteLine("If condition is true");

                if (nestedallowed == true)
                {
                    Console.WriteLine("nested If condition is true");
                }
                else
                {
                    Console.WriteLine("nested If condition is false");
                }

            }
            else
            {
                Console.WriteLine("If condition is false");
            }

            Console.Read();
        }
    }
}
