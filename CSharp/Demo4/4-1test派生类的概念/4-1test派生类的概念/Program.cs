using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_1test派生类的概念
{
 //   sealed 
        class  person
    {
        public virtual void jicheng()
        {
            Console.WriteLine("这是父类");
        }
        
    }
    class student:person
    {
        public override void jicheng()
        {
            Console.WriteLine("这是子类");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            person s = new person();
            student p = new student();
            s.jicheng();
            p.jicheng();
            Console.ReadKey();
        }
    }
}
