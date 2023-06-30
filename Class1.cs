using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbmLibrary
{
    public class calculator
    {
        public void addition(int a, int b)
        {
            Console.WriteLine("Addition result is : "+(a+b));
        }

        public void subtraction(int a, int b)
        {
            Console.WriteLine("subtraction result is : " + (a - b));
        }

        public void multiplication(int a, int b)
        {
            Console.WriteLine("Mulitplication result is : " + (a * b));
        }

        public void division(int a, int b)
        {
            Console.WriteLine("Division result is : " + (a / b));
        }
    }
}
