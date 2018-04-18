using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_3接口索引器
{


    public interface IAddress
    {
        string this[int index] { get; set; }  //声明索引器
        string getAddress();                 //声明方法
    }
    public class Address : IAddress          //从接口派生
    {
        private string[] addr = new string[5];
        public string this[int index]        //实现接口的索引器
        {
            get
            {
                if (index < 0 || index >= 5) return addr[0];
                else return addr[index];
            }
            set
            {
                if (index < 0 || index >= 5) addr[0] = value;
                else addr[index] = value; 
            }
        }
        public string getAddress()          //实现接口的方法，返回地址信息
        {
            string s = addr[0] + "省";
            s += addr[1] + "市";
            s += addr[2] + "街";
            s += addr[3] + "号";
            s += addr[4] + "单元";
            return s;
        }
    }
    public class Student
    {
        public string Name;
        public Address Addr = new Address();
        public Student(params string[] info)   //声明构造函数
        {
            Name = info[0];
            for (int i = 0; i < info.Length - 1; i++) //通过索引器保存地址信息
            {
                Addr[i] = info[i + 1];
            }
        }
        public string Answer()                 //返回某个学生的信息
        {
            string s = "姓名：" + Name + "\n";
            s += "地址：" + Addr.getAddress();
            return s;
        }
    }
    public class TestIndexer
    {
        static void Main()
        {
            //创建Student对象，保存并输出学生信息
            Student stud = new Student("余果", "四川", "成都", "羊市", "120", "4-9-1");
            Console.WriteLine(stud.Answer());
            stud = new Student("何苗", "山西", "大同", "大禹", "210", "1-2-8");
            Console.WriteLine(stud.Answer());
            Console.ReadKey();
        }
    }

    
}
