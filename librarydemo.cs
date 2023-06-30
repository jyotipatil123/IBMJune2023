// class library demo

using System;
using IbmLibrary;


namespace ConsoleApp_IBMJune2023
{
     class librarydemo
    {

        static void Main(string[] args)
        {
            calculator obj= new calculator();
            obj.addition(10,2);
            obj.subtraction(10, 2);
            obj.multiplication(10, 2);
            obj.division(10, 2);



            Console.ReadLine();
        }
    }
}
