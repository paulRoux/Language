using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_2索引器
{
    class person
    {
        private string name1="五毛";
        private string name2 = "二毛";
        public string this[int Index]
        {
            set 
            {
                if (Index==1)
                {
                    name1 = value;
                }
                else if (Index==2)
                {
                    name2 = value;
                }
                else
                    throw new Exception("error@!");
            }
            get
            {
                if (Index == 1)
                {
                    return name1;
                }
                else if (Index == 2)
                {
                    return name2;
                }
                else
                    throw new Exception();
 
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                person p = new person();
                p[2] = "小明";
                Console.WriteLine(p[2] + p[1]);
                
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
