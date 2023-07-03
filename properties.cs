////////////////// Properties : user defined, system defined 

////////////////// automatic property demo 
//////////////////using System;

//////////////////namespace ConsoleApp_IBMJune2023
//////////////////{
//////////////////    class employee
//////////////////    {
//////////////////        public int Id      {  get;  set;  }
//////////////////        public string Name { get; set; }
//////////////////        public string Description { get; set; }
//////////////////    }

//////////////////    class myclass
//////////////////    {
//////////////////        static void Main(string[] args)
//////////////////        {
//////////////////            employee emp= new employee();
//////////////////            emp.Id = 1;
//////////////////            emp.Name = "anita";
//////////////////            emp.Description = "good girl";

//////////////////            Console.WriteLine("Employee id is : "+emp.Id);
//////////////////            Console.WriteLine("Employee name is : " + emp.Name);
//////////////////            Console.WriteLine("Employee description is : " + emp.Description);
//////////////////            Console.ReadLine();
//////////////////        }
//////////////////    }

//////////////////}


//////////////////// read only demo 
//////////////////using System;

//////////////////namespace ConsoleApp_IBMJune2023
//////////////////{
//////////////////    class employee
//////////////////    {
//////////////////        int id = 10;
//////////////////        string name = "sunita";
//////////////////        string desc = "good";

//////////////////        public int Id      
//////////////////        {
//////////////////            get
//////////////////            {
//////////////////                return id;
//////////////////            }
//////////////////        }
//////////////////        public string Name 
//////////////////        {
//////////////////            get
//////////////////            {
//////////////////                return name;
//////////////////            }
//////////////////        }
//////////////////        public string Description 
//////////////////        { 
//////////////////            get
//////////////////            {
//////////////////                return desc;
//////////////////            }
//////////////////        }
//////////////////    }

//////////////////    class myclass
//////////////////    {
//////////////////        static void Main(string[] args)
//////////////////        {
//////////////////            employee emp = new employee();
//////////////////            //error 
//////////////////            //emp.Id = 1;
//////////////////            //emp.Name = "anita";
//////////////////            //emp.Description = "good girl";

//////////////////            Console.WriteLine("Employee id is : " + emp.Id);
//////////////////            Console.WriteLine("Employee name is : " + emp.Name);
//////////////////            Console.WriteLine("Employee description is : " + emp.Description);

//////////////////            Console.ReadLine();
//////////////////        }
//////////////////    }
//////////////////}


////////////////// write only demo 
//////////////////using System;

//////////////////namespace ConsoleApp_IBMJune2023
//////////////////{
//////////////////    class employee
//////////////////    {
//////////////////        int id;
//////////////////        string name;
//////////////////        string desc;
//////////////////        public int Id
//////////////////        {
//////////////////            set
//////////////////            {
//////////////////                id = value;
//////////////////            }
//////////////////        }
//////////////////        public string Name
//////////////////        {
//////////////////            set
//////////////////            {
//////////////////                name= value;
//////////////////            }
//////////////////        }
//////////////////        public string Description
//////////////////        {
//////////////////            set
//////////////////            {
//////////////////                desc= value;
//////////////////            }
//////////////////        }
//////////////////    }

//////////////////    class myclass
//////////////////    {
//////////////////        static void Main(string[] args)
//////////////////        {
//////////////////           employee obj= new employee();

//////////////////            obj.Id = 10;
//////////////////            obj.Name = "sunita";
//////////////////            obj.Description = "good";

//////////////////         //   Console.WriteLine(obj.Id);          // error 

//////////////////            Console.ReadLine();
//////////////////        }
//////////////////    }

//////////////////}

////////////////// read and write property 
////////////////using System;

////////////////namespace ConsoleApp_IBMJune2023
////////////////{
////////////////    class employee
////////////////    {
////////////////        int id=0;
////////////////        string name="anita";
////////////////        string desc="good";
////////////////        public int Id
////////////////        {
////////////////            get
////////////////            {
////////////////              if(id >= 1)   
////////////////                    return id;
////////////////              else
////////////////                    return 0;
////////////////            }
////////////////            set
////////////////            {
////////////////                id = value;
////////////////            }
////////////////        }
////////////////        public string Name
////////////////        {
////////////////            get
////////////////            {
////////////////                return name;
////////////////            }

////////////////            set
////////////////            {
////////////////                name = value;
////////////////            }
////////////////        }
////////////////        public string Description
////////////////        {
////////////////            get
////////////////            {
////////////////                return desc;
////////////////            }
////////////////            set
////////////////            {
////////////////                desc = value;
////////////////            }
////////////////        }
////////////////    }
////////////////    class myclass
////////////////    {
////////////////        static void Main(string[] args)
////////////////        {
////////////////            employee emp = new employee();           

////////////////            Console.WriteLine("Employee id is : " + emp.Id);
////////////////            Console.WriteLine("Employee name is : " + emp.Name);
////////////////            Console.WriteLine("Employee description is : " + emp.Description);

////////////////            Console.ReadLine();
////////////////        }
////////////////    }
////////////////}
////////////////=======================================================================

////////////////Exception handling 
//////////////// types : system defined / user defined 
/////////////////        design time, run time 
/////////////////        

////////////using System;

////////////class MyClass
////////////{
////////////    static void Main(string[] args)
////////////    {
////////////        try
////////////        {
////////////            Console.WriteLine("Enter first number : ");
////////////            int num1 = int.Parse(Console.ReadLine());

////////////            Console.WriteLine("Enter second number : ");
////////////            int num2 = int.Parse(Console.ReadLine());

////////////            double result = num1 / num2;

////////////            Console.WriteLine("Division result is : " + result);
////////////        }
////////////        //catch (Exception ex)
////////////        //{
////////////        //    Console.WriteLine(ex.ToString());
////////////        //}

////////////        // or

////////////        //catch
////////////        //{

////////////        //}
////////////        //or
////////////        catch (Exception ex)
////////////        {
////////////            Console.WriteLine("Please check the inputs " + ex.ToString());
////////////        }

////////////        Console.ReadLine();
////////////    }
////////////}



////////////// user defined exceptions 
////////////using System;
////////////public class InvalidAgeException : Exception
////////////{
////////////    public InvalidAgeException(String message)
////////////        : base(message)
////////////    {

////////////    }
////////////}
////////////public class TestUserDefinedException
////////////{
////////////    static void validate(int age)
////////////    {
////////////        if (age < 18)
////////////        {
////////////            throw new InvalidAgeException("Sorry, Age must be greater than 18");
////////////        }
////////////    }
////////////    public static void Main(string[] args)
////////////    {
////////////        try
////////////        {
////////////            validate(12);
////////////        }

////////////        catch (InvalidAgeException e) 
////////////        {
////////////            Console.WriteLine(e);

////////////        }


////////////        Console.WriteLine("Rest of the code");

////////////        Console.ReadLine();
////////////    }
////////////}

//////////// create a user defined exception -- to check the balance. 


////////////==============================================================

//////////// namespaces 

//////////using System;


//////////namespace B
//////////{
//////////    class car
//////////    {
//////////        public void color()
//////////        {
//////////            Console.WriteLine("car --- color() is invoked");
//////////        }
//////////    }
//////////}

//////////namespace C
//////////{
//////////    class aeroplane
//////////    {
//////////        public void fly()
//////////        {
//////////            Console.WriteLine("aeroplane --- fly() is invoked");
//////////        }
//////////    }
//////////}

//////////class MyClass
//////////{
//////////    static void Main(string[] args)
//////////    {
//////////        A.vehicle obj= new A.vehicle();
//////////        obj.engine();

//////////        B.car obj2 = new B.car();
//////////        obj2.color();

//////////        C.aeroplane obj3 = new C.aeroplane();
//////////        obj3.fly(); 


//////////        Console.ReadLine();
//////////    }
//////////}

////////// file handling 
////////// read, write , copy, move, rename.....

////////using System;
////////using System.IO;

////////class MyClass
////////{
////////    static void Main(string[] args)
////////    {
////////        //FileInfo f1 = new FileInfo(@"c:\demo\ibm\file1.txt");
////////        //Console.WriteLine("File name : "+f1.Name);
////////        //Console.WriteLine("File extension : " + f1.Extension);
////////        //Console.WriteLine("File creation time  : " + f1.CreationTime);
////////        //Console.WriteLine("File last write time : " + f1.LastWriteTime);
////////        //Console.WriteLine("File length is  : " + f1.Length);
////////        //Console.WriteLine("File is present in : : " + f1.Directory);

////////        //DirectoryInfo f2 = new DirectoryInfo(@"c:\demo\ibm");
////////        //Console.WriteLine("Directory name : " + f2.Name);
////////        //Console.WriteLine("Directory exists ?  : " + f2.Exists);
////////        //Console.WriteLine("Directory creation time  : " + f2.CreationTime);
////////        //Console.WriteLine("Directory last write time is : " + f2.LastWriteTime);
////////        //Console.WriteLine("Directory creation time is :  : : " + f2.CreationTime);

////////        //DriveInfo f3 = new DriveInfo("c:\\");
////////        //Console.WriteLine("drive name : " + f3.Name);
////////        //Console.WriteLine("drive total size is  : " + f3.TotalSize);
////////        //Console.WriteLine("drive total free space : " + f3.TotalFreeSpace);
////////        //Console.WriteLine("drive volume label : " + f3.VolumeLabel);
////////        //Console.WriteLine("drive type  : " + f3.DriveType);

////////        //// stream writer class     
////////        //Console.WriteLine("Writing in to the file : ");
////////        //StreamWriter sw = new StreamWriter("c:\\demo\\ibm\\file1.txt");

////////        //// To write on the console screen
////////        //Console.WriteLine("Enter the Text that you want to write on File");

////////        //// To read the input from the user
////////        //string str = Console.ReadLine();

////////        //// To write a line in buffer
////////        //sw.WriteLine(str);

////////        //// To write in output stream
////////        //sw.Flush();

////////        //// To close the stream
////////        //sw.Close();

////////        //Console.WriteLine("Reading from the file : ");
////////        ///// reading from a file
////////        //StreamReader sr = new StreamReader("c:\\demo\\ibm\\file1.txt");

////////        //Console.WriteLine("Content of the File");

////////        //// This is use to specify from where 
////////        //// to start reading input stream
////////        //sr.BaseStream.Seek (0, SeekOrigin.Begin);

////////        //// To read line from input stream
////////        //string str1 = sr.ReadLine();

////////        //// To read the whole file line by line
////////        //while (str1 != null)
////////        //{
////////        //    Console.WriteLine(str1);
////////        //    str1 = sr.ReadLine();
////////        //}

////////        // create a file
////////        //string path = "c:\\demo\\ibm\\a.txt";
////////        //FileStream fs = File.Create(path);        

////////        StreamWriter sw = new StreamWriter("c:\\demo\\ibm\\a.txt");
////////        sw.WriteLine("this is test");
////////        sw.WriteLine("i am testing with c# program");
////////        sw.Flush();
////////        sw.Close(); 

////////        Console.ReadLine();
////////    }
////////}


//////// access specifiers  : private, public, protected, internal, protected internal

////////using System;
////////using System.Collections.Concurrent;

////////class MyClass
////////{
////////    private void myfunction1()
////////    {
////////        Console.WriteLine("this is myfunction1()--private");
////////    }
////////    public void function1()
////////    {
////////        Console.WriteLine("private function1() is invoked");
////////        myfunction1 ();
////////    }
////////    protected void function3()
////////    {
////////        Console.WriteLine("function3() is protected");
////////    }
////////}

////////class india : MyClass
////////{
////////    public void function2()
////////    {
////////        Console.WriteLine("private function1() is invoked");
////////        function3 ();
////////    }
////////}

////////class newclass
////////{
////////    static void Main(string[] args)
////////    {
////////        MyClass obj= new MyClass();
////////        obj.function1 ();

////////        india obj1= new india();
////////        obj1.function2 ();

////////        india obj2= new india();
////////        obj2.function1 ();
////////        obj2.function2 ();

////////        Console.ReadLine();
////////    }
////////}

//////// INTERNAL ACCESS SPECIFIER 

//////using System;

//////namespace RectangleApplication
//////{
//////    class Rectangle
//////    {
//////        internal double length;
//////        internal double width;
//////        double GetArea()
//////        {
//////            return length * width;
//////        }
//////        public void Display()
//////        {
//////            Console.WriteLine("Length: {0}", length);
//////            Console.WriteLine("Width: {0}", width);
//////            Console.WriteLine("Area: {0}", GetArea());
//////        }
//////    }

//////    class Demo
//////    {
//////        static void Main(string[] args)
//////        {
//////            Rectangle rc = new Rectangle();
//////            rc.length = 10.35;
//////            rc.width = 8.3;

//////            rc.Display();

//////            Console.ReadLine();
//////        }
//////    }
//////}


////// boxing and unboxing 
////using System;

////class MyClass
////{
////    static void Main(string[] args)
////    {
////        int a = 100;
////        int b;
////        b = a;

////        Console.WriteLine(a);
////        Console.WriteLine(b);

////        double d = a;
////        Console.WriteLine(d);

////        double e = 898989.89898;
////       // a = e;   //error

////        object obj= new object();
////        Console.WriteLine(obj);

////        obj = a;
////        Console.WriteLine(obj);

////        obj = e;
////        Console.WriteLine(obj);


////        // object, var 
////        int i = 123;
////        object o = (object)i;
////        Console.WriteLine(o);

////        Console.ReadLine();
////    }
////}


//// strings 

//using System;
//using System.Linq;

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        string s1 = "IBM June 2023 batch";
//        Console.WriteLine(s1);

//        Console.WriteLine(s1.ToLower());
//        Console.WriteLine(s1.ToUpper());
//        Console.WriteLine(s1.Contains("IBM"));
        
//        string s2 = "capgemini";

//        Console.WriteLine(String.Concat(s1,s2));
//        Console.WriteLine(s1.Substring(0, 3));
//        Console.WriteLine(s1.Replace('b', 'B'));
        
//        Console.ReadLine();
//    }
//}