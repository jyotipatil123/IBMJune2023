////////////////////// delegates demo
////////////////////// multicast delegate

////////////////////using System;


////////////////////namespace ConsoleApp_IBMJune2023
////////////////////{
////////////////////    public delegate void mydelegate();
////////////////////     class delegates
////////////////////    {
////////////////////        static void Main(string[] args)
////////////////////        {
////////////////////            delegates obj= new delegates();

////////////////////            mydelegate obj1= new mydelegate(obj.function1);
////////////////////            obj1 += obj.function2;
////////////////////            obj1 -= obj.function3;

////////////////////            obj1();

////////////////////            Console.ReadLine();
////////////////////        }

////////////////////        public void function1()
////////////////////        {
////////////////////            Console.WriteLine("static void function1() is invoked");
////////////////////        }
////////////////////        public void function2()
////////////////////        {
////////////////////            Console.WriteLine("static void function2() is invoked");
////////////////////        }
////////////////////        public void function3()
////////////////////        {
////////////////////            Console.WriteLine("static void function3() is invoked");
////////////////////        }
////////////////////    }
////////////////////}


//////////////////// taking the input
//////////////////using System;


//////////////////namespace ConsoleApp_IBMJune2023
//////////////////{
//////////////////    public delegate void mydelegate(int x, int y);
//////////////////    class delegates
//////////////////    {
//////////////////        static void Main(string[] args)
//////////////////        {
//////////////////            delegates obj = new delegates();

//////////////////            mydelegate obj1 = new mydelegate(obj.addition);
//////////////////            obj1 += obj.multiplication;

//////////////////            Console.WriteLine("Enter first number : ");
//////////////////            int num1= int.Parse(Console.ReadLine());

//////////////////            Console.WriteLine("Enter second number : ");
//////////////////            int num2 = int.Parse(Console.ReadLine());

//////////////////            obj1(num1,num2);

//////////////////            Console.ReadLine();
//////////////////        }

//////////////////        public void addition( int a,  int b ) 
//////////////////        {
//////////////////            Console.WriteLine("Addition result is :"+(a+b));
//////////////////        }
//////////////////        public void multiplication(int a, int b)
//////////////////        {
//////////////////            Console.WriteLine("Multiplication result is :" + (a * b));
//////////////////        }
//////////////////    }
//////////////////}


////////////////// anonymous functions 

////////////////using System;

////////////////namespace ConsoleApp_IBMJune2023
////////////////{
////////////////    public delegate void mydelegate(int x, int y);
////////////////    class delegates
////////////////    {
////////////////        static void Main(string[] args)
////////////////        {
////////////////            // anonymous funciton /delegate
////////////////            mydelegate result= delegate(int x, int y)
////////////////            {
////////////////               Console.WriteLine("Addition result is : "+(x+y));               
////////////////            };

////////////////            result(10,2);

////////////////            Console.ReadLine();
////////////////        }
////////////////    }
////////////////}

//////////////// C# --generics 

//////////////using System;
//////////////using System.Collections;
//////////////using System.Collections.Generic;

//////////////class MyClass
//////////////{
//////////////    static void Main(string[] args)
//////////////    {
//////////////        Stack<int> stack = new Stack<int>();
//////////////        stack.Push(1);
//////////////        stack.Push(2);
//////////////        stack.Push(3);

//////////////        Console.WriteLine("Stack elements are : ");
//////////////        foreach (var item in stack)
//////////////        {
//////////////            Console.WriteLine(item);
//////////////        }

//////////////        Stack<string> stack1 = new Stack<string>();
//////////////        stack1.Push("aa");
//////////////        stack1.Push("bb");
//////////////        stack1.Push("cc");

//////////////        Console.WriteLine("Stack elements are : ");
//////////////        foreach (var item in stack1)
//////////////        {
//////////////            Console.WriteLine(item);
//////////////        }

//////////////        Queue<string> queue = new Queue<string>();
//////////////        queue.Enqueue("aa");
//////////////        queue.Enqueue("bb");
//////////////        queue.Enqueue("cc");

//////////////        Console.WriteLine("Queue elements are : ");
//////////////        foreach (var item in queue)
//////////////        {
//////////////            Console.WriteLine(item);
//////////////        }

//////////////       // ArrayList list = new ArrayList(); // non generic collection 


//////////////        Console.ReadLine();
//////////////    }
//////////////}

////////////// generic class
////////////// T generic data type 

////////////using System;

////////////namespace A
////////////{
////////////    public class IBMClass<T>
////////////    {
////////////        public T msg;
////////////        public void IbmMethod(T name, T location)
////////////        {
////////////            Console.WriteLine("{0}", msg);
////////////            Console.WriteLine("Name: {0}", name);
////////////            Console.WriteLine("Location: {0}", location);
////////////        }
////////////    }
////////////    class Program
////////////    {
////////////        static void Main(string[] args)
////////////        {
////////////            Console.WriteLine("****Generics Example****");

////////////            // Instantiate Generic Class, string is the type argument

////////////            IBMClass<string> gclass = new IBMClass<string>();

////////////            gclass.msg = "Welcome to IBM";

////////////            gclass.IbmMethod("Ananya", "Hyderabad");
////////////            Console.ReadLine();
////////////        }
////////////    }
////////////}

//////////// generic methods 
//////////using System;

//////////namespace A
//////////{
//////////    public class SampleClass
//////////    {
//////////        public void GMethod<T>(T a, T b)
//////////        {
//////////            Console.WriteLine("Param1: {0}", a);
//////////            Console.WriteLine("Param2: {0}", b);
//////////        }
//////////    }
//////////    class Program
//////////    {
//////////        static void Main(string[] args)
//////////        {
//////////            Console.WriteLine("****Generics Method Example****");

//////////            SampleClass s = new SampleClass();

//////////            s.GMethod<int>(1, 2);

//////////            s.GMethod<string>("Anita", "Gujrat");

//////////            s.GMethod<char>('a','b');

//////////            Console.ReadLine();
//////////        }
//////////    }
//////////}

////////// generic delegate 

////////using System;

////////namespace A
////////{
////////    // Declare Generic Delegate
////////    public delegate T SampleDelegate<T>(T a, T b);  //declare
////////    class MathOperations
////////    {
////////        public int Add(int a, int b)
////////        {
////////            return a + b;
////////        }
////////        public int Subtract(int x, int y)
////////        {
////////            return x - y;
////////        }
////////    }
////////    class Program
////////    {
////////        static void Main(string[] args)
////////        {
////////            Console.WriteLine("****Generic Delegate Example****");
////////            MathOperations m = new MathOperations();

////////            // Instantiate delegate with add method
////////            SampleDelegate<int> dlgt = new SampleDelegate<int>(m.Add);  //assign
////////            Console.WriteLine("Addition Result: " + dlgt(10, 90)); //invoke

////////            // Instantiate delegate with subtract method
////////            dlgt = m.Subtract;
////////            Console.WriteLine("Subtraction Result: " + dlgt(10, 90));

////////            Console.ReadLine();
////////        }
////////    }
////////}

//////// Events in c#

//////using System;

//////namespace SampleApp
//////{
//////    public delegate string MyDel(string str);
//////    class EventProgram
//////    {
//////        event MyDel MyEvent;

//////        public EventProgram()
//////        {
//////            this.MyEvent += new MyDel(this.WelcomeUser);
//////        }
//////        public string WelcomeUser(string username)
//////        {
//////            return "Welcome " + username;
//////        }
//////        static void Main(string[] args)
//////        {
//////            EventProgram obj1 = new EventProgram();

//////            string result = obj1.MyEvent("IBM June 2023");

//////            Console.WriteLine(result);

//////            Console.ReadLine();
//////        }
//////    }
//////}

//////================================================================
////// constructors

////using System;

////class person
////{
////    int id;
////    string name;

////    public person()   // default constructor
////    {
////        Console.WriteLine("default constructor");
////    }
////    public person(int id1, string name1)  // parameterized constructor 
////    {
////        this.id = id1;
////        this.name = name1;
////    }
////    public void output() 
////    {
////        Console.WriteLine("id is : "+id);
////        Console.WriteLine("Name is : "+name); 
////    }
////}
////class MyClass
////{
////    static void Main(string[] args)
////    {
////        person p2= new person();

////        person p1 = new person(10, "Ananya");
////        p1.output();

////        Console.ReadLine();
////    }
////}


////private constructor

//using System;

//namespace A
//{
//    class User
//    {
//        // Private Constructor
//        private User()
//        {
//            Console.WriteLine("I am Private Constructor");
//        }

//        public static string name, location;

//        // Default Constructor
//        public User(string a, string b)
//        {
//            name = a;
//            location = b;
//        }

//        public void display()
//        {
//            User u1= new User();
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // The following comment line will throw an error because the constructor is inaccessible
//            //User user = new User();

//            // Only the Default constructor with parameters will invoke
//            User user1 = new User("Suresh", "Hyderabad");

//            Console.WriteLine(User.name + ", " + User.location);

//            user1.display();
           
//            Console.ReadLine();
//        }
//    }
//}

//// Home work : static constructor and copy constructor 