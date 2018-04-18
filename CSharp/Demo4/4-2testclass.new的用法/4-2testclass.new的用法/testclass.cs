using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_2testclass.new的用法
{
    public class person
    {
        public string id;
        public string Name;

        public string Answer()
        {
            return string.Format("座位号：{0}，姓名：{1}", id, Name);
        }
    }
    public class student:person
    {
        public new string id;

        public new string Answer()
        {   
            return string.Format("学号：{0},姓名：{1}", id, Name);
        }
        
    }
    
    
    class testclass
    {
        static void Main(string[] args)
        {
            person a = new person();
            student s = new student();
            a.id = "1001";

            s.id = "1111";
            s.Name = a.Name="陈好";

            Console.WriteLine(s.Answer()+"\n"+a.Answer());

            Console.WriteLine(s.id);            
            Console.WriteLine(((person)s).Answer());

            Console.ReadKey();
        }
    }
}
