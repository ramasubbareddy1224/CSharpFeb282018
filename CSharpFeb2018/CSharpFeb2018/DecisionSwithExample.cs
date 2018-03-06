using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeb2018
{
   public class DecisionSwithExample
    {
        static void Main()
        {
            string favoritecolor = "blue";
            switch (favoritecolor)
            {
                case "red":
                    Console.WriteLine("you choosen red");
                    break;
                case "blue":
                    Console.WriteLine("you choosen blue");
                    break;
                case "yellow":
                    Console.WriteLine("you choosen yellow");
                    break;
                default:
                    Console.WriteLine("you choosen invalid");
                    break;
            }

            Console.Read();
        }
    }
}
