using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
    public class ExceptionHandlingExample
    {
        public void Display()
        {
            try
            {
                // Divide by Zero Exception

                int a = 10;
                //int b = a / 0;

                // array index out of range exception
                int[] intarray = { 10, 20 };
                Console.WriteLine("read intarray:" + intarray[2]);
            }
            catch (Exception e)
            {
                Console.WriteLine("sorry for the inconvience. Please try again");
                Console.WriteLine("exception details:"+e.Message);
                Console.WriteLine("exception more details:" + e.StackTrace);
            }
            finally
            {
                Console.WriteLine("this is finally block");
            }

        }
    }
}
