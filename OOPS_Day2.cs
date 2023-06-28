//////// interfaces and abstract classes with inheritance
////////using System;


////////namespace ConsoleApp_IBMJune2023
////////{
////////    interface i1       {       void function1();   }   //pure abstract functions   //c# 7.0 
////////    interface i2 :i1   {       void function2();   }
////////    class ibm : i2
////////    {
////////        public void function1()
////////        {
////////            Console.WriteLine("i1 function1() is invoked");
////////        }
////////         public void function2()
////////        {
////////            Console.WriteLine("i2 function2() is invoked");
////////        }
////////    }
////////    class MyClass1
////////    {
////////        static void Main()
////////        {
////////            ibm obj= new ibm();
////////            obj.function1();
////////            obj.function2();

////////            Console.ReadLine();
////////        }
////////    }
////////}


////////sealed keyword

////////using System;

////////sealed class MyClass
////////{
////////    int i=10, j=20;

////////    public void display()
////////    {
////////        Console.WriteLine(i);
////////        Console.WriteLine(j);
////////    }
////////}

////////class india : MyClass
////////{

////////}

////////===========================================

//////using System;


//////namespace ConsoleApp_IBMJune2023
//////{
//////    interface i1 
//////    { 
//////        void function1();
//////    } 
//////    //pure abstract functions   //c# 7.0 
//////    interface i2 
//////    {
//////        void function2();
//////    }
//////    class ibm : i1, i2
//////    {

//////        // implicit interface implementation
//////        //public void function1()
//////        //{
//////        //    Console.WriteLine("i1---function1() is invoked");
//////        //}

//////        //public void function2()
//////        //{
//////        //    Console.WriteLine("i2----function2() is invoked");
//////        //}

//////        // explicit interface implementation 
//////        void i1.function1()
//////        {
//////            Console.WriteLine("explicit function1() is invoked ");
//////        }

//////        void i2.function2()
//////        {
//////            Console.WriteLine("explicit function2() is invoked ");
//////        }
//////    }
//////    class MyClass1
//////    {
//////        static void Main()
//////        {
//////            ibm obj = new ibm();
//////            obj.function1();
//////            obj.function2();

//////            Console.ReadLine();
//////        }
//////    }
//////}


////// abstract class inheritance

////using System;

////abstract class A
////{
////    public abstract void function1();
////}

////abstract class B : A
////{
////    public abstract void function2();
////}

////class ibm : B
////{
////    public override void function1()
////    {
////        Console.WriteLine("ibm --override function1() ");
////    }

////    public override void function2()
////    {
////        Console.WriteLine("ibm---override function2() ");
////    }
////}

////class MyClass
////{
////    static void Main(string[] args)
////    {
////        ibm obj= new ibm();
////        obj.function1 ();


////        Console.ReadLine();
////    }
////}

////===============================================================

//// structures and enums 

//using System;

//struct book
//{
//    int id;
//    public string name;
//    public string description;  

//    public void display()
//    {
//        Console.WriteLine("display() is invoked");
//    }
//}

//enum designations { projmanagers, teamleads, developer, tester};
//enum vehicle { car, jeep, truck, bus, aeroplane};
//enum days { mon, tue, wed, thu};

////struct author :book          //structure inheritance not possible. 
////{

////}
//class MyClass
//{
//    static void Main(string[] args)
//    {
//        //book obj= new book();
//        //obj.name = "c#";
//        //obj.description = "Microsoft";

//        //Console.WriteLine(obj.name) ;
//        //Console.WriteLine(obj.description);
//        //obj.display();

//        book book1;
//        book1.name = "Asp.net book";
//        book1.description = "Good book";
//        Console.WriteLine(book1.name);
//        Console.WriteLine(book1.description);

//        book book2;
//        book2.name = "Asp.net core book";
//        book2.description = "ok book";
//        Console.WriteLine(book2.name);
//        Console.WriteLine(book2.description);

//        book book3;
//        book3.name = "Asp.net mvc  book";
//        book3.description = "not good";
//        Console.WriteLine(book3.name);
//        Console.WriteLine(book3.description);

//        Console.WriteLine("Day 1 is : "+(int) days.mon);
//        Console.WriteLine("Day 2 is : " + days.tue);
//        Console.WriteLine("Day 3 is : "+days.wed);

//        Console.ReadLine();

//    }
//}
//

// collections : stack
// LIFO, push, pop

//using System;
//using System.Collections;

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        //Stack st= new Stack();
//        //st.Push(1);
//        //st.Push(2);
//        //st.Push(3);
//        //st.Push(4);
//        //st.Push(5);
//        //st.Push(6);

//        //Console.WriteLine("Stack elements are : ");
//        //foreach (var item in st)
//        //{
//        //    Console.WriteLine(item);
//        //}

//        //Stack st1 = new Stack();
//        //st1.Push(1);
//        //st1.Push('k');
//        //st1.Push("kavana");
//        //st1.Push(89.8878f);
//        //st1.Push(878787.7878m);
//        //st1.Push(true);

//        //Console.WriteLine("Stack elements are : ");
//        //foreach (var item in st1)
//        //{
//        //    Console.WriteLine(item);
//        //}

//        //st1.Pop();
//        //Console.WriteLine("after pop() Stack elements are : ");
//        //foreach (var item in st1)
//        //{
//        //    Console.WriteLine(item);
//        //}

//        //Console.WriteLine("Stack top is : "+st1.Peek());
//        //Console.WriteLine("Stack count is : "+st1.Count);

//        Queue queue = new Queue();  // FIFO
//        queue.Enqueue(10);
//        queue.Enqueue(20);
//        queue.Enqueue(30);
//        queue.Enqueue(50);
//        queue.Enqueue(100);

//        Console.WriteLine("Queue elements are : ");
//        foreach (var item in queue)
//        {
//            Console.WriteLine(item);
//        }

//        queue.Dequeue();

//        Console.WriteLine("Top most element of queue is : "+ queue.Peek());

//        Console.WriteLine("After dequeue Queue  elements are : ");
//        foreach (var item in queue)
//        {
//            Console.WriteLine(item);
//        }

//        Console.WriteLine("Queue count is : " + queue.Count);

//        Console.WriteLine("Contains : "+ queue.Contains(10));

//        //queue.ToArray();
//        int[] arr = new int[10];

//        queue.CopyTo(arr, 3);

//       // Object obj = new Object();




//        Console.ReadLine();
//    }
//}


// arraylist 
using System;
using System.Collections;
using System.Security.Cryptography;

class MyClass
{
    static void Main(string[] args)
    {
        //ArrayList obj= new ArrayList();
        //obj.Add(1);
        //obj.Add(2);
        //obj.Add(3);
        //obj.Add(4);

        //Console.WriteLine("Array list elements are : ");
        //foreach (var item in obj)
        //{
        //    Console.WriteLine(item);
        //}
       // //obj.Remove(3);
       // //obj.RemoveAt(0);
       //// obj.RemoveRange(1, 2);

       // //obj.CopyTo();
       // //obj.ToArray();

       // Console.WriteLine(obj.Count);
        
       // obj.Clear();
        
        //obj.Reverse();
        //Console.WriteLine("Array list elements are : ");
        //foreach (var item in obj)
        //{
        //    Console.WriteLine(item);
        //}

        //obj.Sort();
        //Console.WriteLine("Array list elements are : ");
        //foreach (var item in obj)
        //{
        //    Console.WriteLine(item);
        //}

        // hashtable and sortedlist

        //hashtable.Clear();

        Hashtable ht = new Hashtable();
        ht.Add (1, "India");
        ht.Add (2, "China");
        ht.Add (3, "US");

        Console.WriteLine("Hash table : ");
        foreach (DictionaryEntry item in ht)
        {
            Console.WriteLine(item.Key+"  " +item.Value);
        }
        //ht.Clear ();
        //ht.Remove (1);
        //ht.CopyTo();
        //ht.Contains (1);

        //ht.ContainsKey (1);
        //ht.ContainsValue (2);


        Console.WriteLine("Sortedlist is : ");
        SortedList sl = new SortedList();
        sl.Add(1, "India");
        sl.Add(2, "China");
        sl.Add(3, "US");

        foreach (DictionaryEntry item in sl)
        {
            Console.WriteLine(item.Key + "  " + item.Value);
        }

        sl.Clear();
        sl.Remove(1);
        sl.RemoveAt(0);
        

        Console.ReadLine();
    }
}







