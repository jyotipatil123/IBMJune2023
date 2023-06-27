//////// oops concepts demo
//////using System;

//////namespace OOPSdemo
//////{
//////     class OOPS
//////    {
//////        static void Main(string[] args)
//////        {
//////            Console.WriteLine("Enter first number : ");
//////            int a = int.Parse(Console.ReadLine());

//////            Console.WriteLine("Enter second number : ");
//////            int b = int.Parse(Console.ReadLine());

//////            Console.WriteLine("Addition result is : "+(a+b));

//////            Console.ReadLine();
//////        }
//////    }
//////}

//////===========================================================

//////using System;

//////class vehicle
//////{
//////    int id = 101;
//////    string name = "keval";
//////    public void displaydetails()
//////    {
//////        Console.WriteLine("Vehicle id is : " + id);
//////        Console.WriteLine("Vehicle name is : " + name);
//////    }
//////    public static void function1()
//////    {
//////        Console.WriteLine("static void function1()");
//////    }
//////}
//////class myclass
//////{ 
//////    static void Main()
//////    {
//////        vehicle v1 = new vehicle();
//////        v1.displaydetails();

//////        //function1();

//////        Console.ReadLine();
//////    }
//////}

////// inheritance 

////using System;

////class vehicle
////{
////    int id = 101;
////    string make = "1999";
////    public void displaydetails()
////    {
////        Console.WriteLine("Vehicle id is : " + id);
////        Console.WriteLine("Vehicle make is : " + make);
////    }
////}
////class car :vehicle      // single level inheritance 
////{ 
////    public void carcolor()
////    {
////        Console.WriteLine("Available car colors : red, blue");
////    }
////}

////class bus : vehicle   //hierarchical inheritance
////{

////}
//// class jeep : car   // multi level inheritance 
////{
////    public void jeepcolor()
////    {
////        Console.WriteLine("Jeep color is green" );
////    }
////}
////class myclass
////{
////    static void Main()
////    {
////        //vehicle obj1= new vehicle();
////        //obj1.displaydetails();

////        //car obj2= new car();
////        //obj2.carcolor();

////        // single level inheritance 
////        car obj1= new car();
////        obj1.displaydetails();
////        obj1.carcolor();


////        // multi level inheritance 
////        jeep obj2= new jeep();  
////        obj2.displaydetails();
////        obj2.carcolor();
////        obj2.jeepcolor();
////        Console.ReadLine();
////    }
////}



//// sealed keyword
//using System;

//sealed class vehicle
//{
//    int id = 101;
//    string make = "1999";
//    public void displaydetails()
//    {
//        Console.WriteLine("Vehicle id is : " + id);
//        Console.WriteLine("Vehicle make is : " + make);
//    }
//}
////class car : vehicle      // single level inheritance 
////{
////    public void carcolor()
////    {
////        Console.WriteLine("Available car colors : red, blue");
////    }
////}

//class A
//{
//    static void Main()
//    {

//        vehicle vehicle = new vehicle();
//        vehicle.displaydetails();

//        Console.ReadLine();
//    }
//}

// polymorphism
// static / design -- function overloading
// same function name with different parameters

//using System;

//class calculator
//{
//    public void add()
//    {
//        int a = 10;
//        int b = 20;
//        Console.WriteLine("Addition result is : "+ (a+b));
//    }
//    public void add(int a)
//    {
//       Console.WriteLine("Addition result is : " + (a + a));
//    }

//    public void add(int a,int b)
//    {
//        Console.WriteLine("Addition result is : " + (a + b));
//    }

//    public void add(int a, int b, int c)
//    {
//        Console.WriteLine("Addition result is : " + (a + b+c));
//    }
//}

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        calculator c1= new calculator();
//        c1.add();
//        c1.add(1);
//        c1.add(2, 3);
//        c1.add(2, 3, 4);

//        Console.ReadLine();
//    }
//}

// function overriding 

//using System;
//class india
//{
//    public virtual void culture()
//    {
//        Console.WriteLine("India has got great culture");
//    }
//}

//class Delhi : india
//{
//    public override void culture()
//    {
//        Console.WriteLine("Delhi has got great culture");
//    }
//}

//class MyClass
//{
//    static void Main()
//    {
//        Delhi obj= new Delhi();
//        obj.culture();


//        Console.ReadLine();
//    }
//}

//========================================================================
// abstract classes 

//using System;

// abstract class atm
//{
//    public abstract void withdraw();  // abstract method

//    public void credit() // non abstract method 3
//    {
//        Console.WriteLine("Amount is credited");
//    }
//}
//class bank : atm
//{
//    public override void withdraw()
//    {
//        Console.WriteLine("Amount is withdrawn");
//    }
//}

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        bank obj= new bank();
//        obj.credit();
//        obj.withdraw();

//        Console.ReadLine();
//    }
//}



//using System;

//public abstract class Animal
//{
//    public abstract string Sound();
//    public void Move()
//    {
//        Console.WriteLine("Moving...");
//    }
//}

//public class Cat : Animal
//{
//    public override string Sound()
//    {
//        return "meow";
//    }    
//}

//public class Dog : Animal
//{
//    public override string Sound()
//    {
//        return "Woof";
//    }   
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Cat obj1= new Cat();
//        obj1.Sound();

//        Dog obj2= new Dog();
//        obj2.Sound();


//        Console.ReadLine();
//    }
//}


//===========================INTERFACES 
// multiple inheritance concept xxxxxxxxxxxx

//using System;

//interface IAnimal
//{
//    void sound();
//}

//class cat : IAnimal
//{
//    public void sound()
//    {
//        Console.WriteLine("cat sounds Meow ....");
//    }
//}

//class dog : IAnimal
//{
//    public void sound()
//    {
//        Console.WriteLine("Dog sound woof....");
//    }
//}

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        cat obj= new cat();
//        obj.sound();

//        dog obj1= new dog();
//        obj1.sound();

//        Console.ReadLine(); 
//    }
//}
////=======================================================


//using System;

//interface IAnimal     // implement 
//{
//    void sound();
//}

//interface IVehicle
//{
//    void move();
//}

//class cat : IAnimal, IVehicle
//{
//    public void move()
//    {
//        Console.WriteLine("vehicle is moving");
//    }

//    public void sound()
//    {
//        Console.WriteLine("cat sounds Meow ....");
//    }
//}

//class dog : IAnimal
//{
//    public void sound()
//    {
//        Console.WriteLine("Dog sound woof....");
//    }
//}

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        cat obj = new cat();
//        obj.sound();

//        dog obj1 = new dog();
//        obj1.sound();

//        Console.ReadLine();
//    }
//}


// explicit interfaces 
using System;

interface IAnimal     // implement 
{
    void sound();
}

interface IVehicle
{
    void move();
}

class cat : IAnimal, IVehicle
{
    void IVehicle.move()
    {
        Console.WriteLine("vehicle is moving");
    }

    void IAnimal.sound()
    {
        Console.WriteLine("Animal --sound");
    }
    
    public void function1()
    {
        Console.WriteLine("Cat class --- function1() is invoked ");
    }
}
class MyClass
{
    static void Main(string[] args)
    {
        // explicit interface implementation
        IVehicle obj1 = new cat();
        obj1.move();

        IAnimal obj2 = new cat();
        obj2.sound();
        
        cat obj3= new cat();
        obj3.function1();


        Console.ReadLine();
    }
}








