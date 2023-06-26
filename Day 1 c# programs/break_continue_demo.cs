//////////break and continue demo
////////using System;

////////namespace ConsoleApp_IBMJune2023
////////{
////////    class break_continue_demo
////////    {
////////        static void Main()
////////        {
////////            //int a = 10;
////////            //if (a == 10)
////////            //{
////////            //    Console.WriteLine("welcome");
////////            //    break;
////////            //}

////////            // loops
////////            //Console.WriteLine("to display numbers from 1 to 10 : ");
////////            //for (int i = 0;i<10;i++) 
////////            //{
////////            //    Console.WriteLine(i);

////////            //    if(i==5)
////////            //    {
////////            //        Console.WriteLine("welcome");
////////            //        continue;
////////            //    }
////////            //}
////////            int a = 10;
////////            Int16 b1 = 100;
////////            Int32 b2 = 100;
////////            Int64 b3 = 200;

////////            Console.WriteLine(a);
////////            Console.WriteLine(b1);
////////            Console.WriteLine(b2);
////////            Console.WriteLine(b3);
////////            //==============================================

////////            float x1 = 10.533f;
////////            Console.WriteLine(x1);

////////            decimal x2 = 898989.23423m;
////////            Console.WriteLine(x2);

////////            bool x3 = false;
////////            Console.WriteLine(x3);

////////            char x4 = 'a';
////////            Console.WriteLine(x4);

////////            string x5 = "pragya";
////////            Console.WriteLine(x5);


////////            Console.ReadLine(); 
////////        }

////////    }
////////}

////////---------------------------------------------------------
//////// while loop

//////using System;

//////class MyClass
//////{
//////    static void Main()
//////    {
//////        //Console.WriteLine("while loop demo : ");
//////        //int num1 = 1;

//////        //while (num1 <10) 
//////        //{
//////        //    Console.WriteLine(num1);
//////        //    num1++;
//////        //}

//////        //int num2 = 10;

//////        //while (num2 >1)
//////        //{
//////        //    Console.WriteLine(num2);
//////        //    num2--;
//////        //}

//////        // do while loop 

//////        int num1 = 10;

//////        do
//////        {
//////            Console.WriteLine("ibm june 2023 batch");
//////            num1++;

//////        } while (num1 != 10);
//////        Console.ReadLine();
//////    }
//////}

//////====================================================

////// Arrays 
////// holding same type of datas
////using System;

////class MyClass
////{
////    static void Main()
////    {
////        //  int[] arr=new int[5];  //declare
////        //  arr[0] = 10;
////        //  arr[1] = 20;
////        //  arr[2] = 30;
////        //  arr[3] = 40;
////        //  arr[4] = 50;
////        ////  arr[5] = 78;

////        //  foreach (int item in arr)
////        //  {
////        //      Console.WriteLine(item);
////        //  }

////        //int[] arr1 = new int[5] { 8, 2, 3, 4, 8 }; //declare

////        //foreach (int item in arr1)
////        //{
////        //    Console.WriteLine(item);
////        //}

////        //int[] arr = new int[10];
////        //int index = 0;
////        //foreach (int element in arr)
////        //{
////        //    int value = int.Parse(Console.ReadLine());
////        //    arr[index++] = value;
////        //}

////        //foreach (int element in arr)
////        //{
////        //    Console.WriteLine(element);
////        //}

////        //==================================================================

////        int[,] arr1 = new int[2, 2];
////        //   0   1
////        //0  00  01
////        //1  10  11
////        arr1[0, 0] = 1;
////        arr1[0, 1] = 10;
////        arr1[1, 0] = 12;
////        arr1[1, 1] = 2;

////        Console.WriteLine("Double dimensional array : ");
////        for (int i = 0;i<2;i++)  //i=0           i=1
////        {
////            for(int j=0;j<2;j++) //j=0  j=1 j=2  j=0  j=1  j=2
////            {
////                Console.Write(arr1[i,j]+ "   ");
////            }
////            Console.WriteLine();
////        }



////        int[,] arr2 = new int[3, 3];



////        Console.ReadLine();
////    }
////}

////================================addition of matrices 

//using System;

//class MyClass
//{
//    static void Main()
//    {
//        //int[,] arr1= new int[2,2];

//        //for (int i = 0; i < arr1.Length; i++) 
//        //{
//        //  for (int j = 0; j < arr1.Length; j++)
//        //    {

//        //        Console.Write(arr1[i,j]);
//        //    }
//        //    Console.WriteLine();
//        //}

//        //Console.WriteLine("");

//        // Jagged arrays :  c#
//        // array within an array
//        // each array element itself is an array

//        int[][] arr = new int[2][];// Declare the array  

//        arr[0] = new int[] { 11, 21, 56, 78 };// Initialize the array          
//        arr[1] = new int[] { 42, 61, 37, 41, 59, 63 };

//        // Traverse array elements  
//        for (int i = 0; i < arr.Length; i++)
//        {
//            for (int j = 0; j < arr[i].Length; j++)
//            {
//                Console.Write(arr[i][j] + " ");
//            }
//            Console.WriteLine();
//        }

//        Console.ReadLine();
//    }
//}

//========================================================================

// goto statement

using System;

class MyClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Goto demo : ");

        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
                goto a1;

            Console.WriteLine("welcome..........rest of the code ");
        }

        a1:
           Console.WriteLine("Number is 5....so i have exited");


        Console.ReadLine();
    }
}