using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test继承
{
    class person
    {
        public virtual string jicheng()
        {
            string result="我是父类";
            return result;
        }

    }
    class boy : person
    {
        public override string jicheng()
        {
            string result = ("我是子类");

            return result;
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            boy s = new boy();
            Console.WriteLine(p.jicheng());
            Console.WriteLine(s.jicheng());
            Console.ReadKey();
        }
    }
}
