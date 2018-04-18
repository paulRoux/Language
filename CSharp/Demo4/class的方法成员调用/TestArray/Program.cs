using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestArray
{
    class Program
    {
        static void Main(string[] args)
        {
     /*       int[] x = new int[5] { 1, 2, 0, 4, 5 };
            Array.Sort(x);
            Console.WriteLine("\n最小值为：{0}", x[0]);
            Console.ReadKey();*/


            Son s = new Son();
            Console.WriteLine("Son = {0}\tFather = {1}", s.GetAnswer(), ((Father)s).GetAnswer());
            Console.ReadKey();
        }
    }

   //public sealed class  Father
    class Father
    {
        public Father()
        {
        }

        public string GetAnswer()
        {
            return "父类输出";
        }
    }

    class Son : Father
    {
        public Son()
        {
        }
        public new string GetAnswer()
        {
            return "子类输出";
        }
    }
}
