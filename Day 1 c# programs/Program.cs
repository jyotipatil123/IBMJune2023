////using System;

////namespace A
////{
////	class MyClass
////	{
////		static void Main()
////		{
////            Console.Write("welcome all");
////            Console.Write("welcome");

////			int a = 10;
////			int b = 20;
////            Console.WriteLine("a="+a);
////            Console.WriteLine("b="+b);
////            Console.WriteLine("a="+a+"b="+b);

////            Console.WriteLine("{0} {1}",a,b);

////            //operators 
////            //assignment operator  =
////            // relational operator  <  >  <=  >=  != 
////            // logical operator  &&  ||   !
////            // comparison operators ==
////            // bitwise << >>
////            // arithmetic operators  + - *  /  %

////            Console.WriteLine("Enter first number :");
////            int num1 =int.Parse( Console.ReadLine());

////            Console.WriteLine("Enter secomd number :");
////            int num2 = int.Parse(Console.ReadLine());

////            Console.WriteLine("Addition result is : "+(num1+num2));
////            Console.WriteLine("Subtraction result is : " + (num1 - num2));
////            Console.WriteLine("Multiplication result is : " + (num1 * num2));
////            Console.WriteLine("Division result is : " + (num1 / num2));
////            Console.WriteLine("Modulus result is : " + (num1 % num2));

////            Console.WriteLine($"a={a}");
////            Console.WriteLine($"the value of b is ={b}");



////            Console.ReadLine();
////		//	Console.Read();
////		//	Console.ReadKey();

////        }
////	}

////}

//// c# basics 

//// conditional statements

//using System;

//class MyClass
//{
//    public string name = "abc";   // global variable 
//    static void Main()
//    {
//        Console.WriteLine("if condition demo :");
//        int a = 10;

//        if (a == 10)
//            Console.WriteLine(a);
//        else
//            Console.WriteLine("number is not 10");

//        string na = "akhil";
//        MyClass obj = new MyClass();

//        Console.WriteLine("Entered name is : " + na);
//        Console.WriteLine("Entered name is :{0} ", na);
//        Console.WriteLine($"Entered name is :{obj.name} ");

//        Console.WriteLine("Enter your name: ");
//        String name = Console.ReadLine();

//        Console.WriteLine("Enter a string: ");
//        String abc = Console.ReadLine();

//        if (abc == name)
//            Console.WriteLine("Welcome " + name);
//        else
//            Console.WriteLine("Bye " + abc);


//        Console.ReadLine();
//    }

//    public void function1()
//    {

//    }
//}