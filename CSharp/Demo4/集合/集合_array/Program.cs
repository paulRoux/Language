﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 集合_array
{
    class Program
    {
        static void Main(string[] args)
        {


            // Creates and initializes a new integer array and a new Object array.
            int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };
            Object[] myObjArray = new Object[5] { 26, 27, 28, 29, 30 };

            
            // Prints the initial values of both arrays.
            Console.WriteLine("Initially,");
            Console.Write("integer array:");
            PrintValues(myIntArray);
            Console.Write("Object array: ");
            PrintValues(myObjArray);
            Console.ReadKey();

            // Copies the first two elements from the integer array to the Object array.
            System.Array.Copy(myIntArray, myObjArray, 2);

            // Prints the values of the modified arrays.
            Console.WriteLine("\nAfter copying the first two elements of the integer array to the Object array,");
            Console.Write("integer array:");
            PrintValues(myIntArray);
            Console.Write("Object array: ");
            PrintValues(myObjArray);
            Console.ReadKey();

            // Copies the last two elements from the Object array to the integer array.
            System.Array.Copy(myObjArray, myObjArray.GetUpperBound(0) - 1, myIntArray, myIntArray.GetUpperBound(0) - 1, 2);

            // Prints the values of the modified arrays.
            Console.WriteLine("\nAfter copying the last two elements of the Object array to the integer array,");
            Console.Write("integer array:");
            PrintValues(myIntArray);
            Console.Write("Object array: ");
            PrintValues(myObjArray);
            Console.ReadKey();
        }
           


           public static void PrintValues( Object[] myArr )  
           {
              foreach ( Object i in myArr )  
              {
                 Console.Write( "\t{0}", i );
              }
              Console.WriteLine();
           }

           public static void PrintValues( int[] myArr )  
           {
              foreach ( int i in myArr )  
              {
                 Console.Write( "\t{0}", i );
              }
              Console.WriteLine();
           }
        
    }
}
