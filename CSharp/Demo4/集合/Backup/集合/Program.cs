using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace 集合
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");

            // Sorts the values of the ArrayList.
           //myAL.Sort();

            // Displays the values of the ArrayList.
            Console.WriteLine("After sorting:");
            //Console.WriteLine(myAL);

            IEnumerator ie = myAL.GetEnumerator();
            while (ie.MoveNext())                //遍历枚举器
            {
                
                Console.Write(ie.Current+" ");
            
            }
            Console.ReadKey();




           
            
            
            

        }
    }
}
