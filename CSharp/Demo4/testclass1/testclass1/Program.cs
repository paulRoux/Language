using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testclass1
{
    class person
    {
        public virtual string jicheng()
        {
            string result;
            return result = "我是父类";
        }
    }

    class son : person
    {
        //public override string jicheng()
        //{
        //    string result;
        //    return result = "我是子类";
        //}

    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            son s = new son();
            Console.WriteLine(p.jicheng());
            Console.WriteLine(s.jicheng());
            Console.ReadKey();

        }
    }
}
