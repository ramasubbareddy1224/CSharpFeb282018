using System;
namespace Pragim.CSharp
{
    class FirstProg
    {
        static void Main()
        {
            Console.WriteLine("This is first program");

            int number = 100;
            double decimalnumber = 222.34;
            string stringtext = "pragim";
            char charactertext = 'A';
            bool booltype = true;

            Console.WriteLine(number);
            Console.WriteLine("mycharactertext is:" + charactertext + " and this is charcter type");
            Console.WriteLine(string.Format("mycharactertext is:{0} and this is charcter type", charactertext));
            Console.WriteLine(string.Format("number is:{0} and decimal number is:{1}", number, decimalnumber));

            Console.Read();
        }
    }
}
