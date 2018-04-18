using System;
using System.Collections;

namespace _5_1hashtable
{
    
        class Student
        {
            public string Name;
            public char Sex;
            public Student (string name, char sex)   //构造函数
            {
                Name = name;
                Sex = sex;
            }
            public string Answer()
            {
                return "姓名：" + Name + " 性别：" + Sex;
            }
        }
        public class TestHash
        {
            static void Main()
            {
                Hashtable h = new Hashtable();       //创建哈希表对象
                Student p = new Student("黄鸿", '男');
                h.Add("甲", p); //将键/值对存入哈希表，键为"甲"，值为学生对象
                p = new Student("何娟", '女');
                h.Add("乙", p);
                p = new Student("王川", '男');
                h.Add("丙", p);

                IEnumerator ie = h.GetEnumerator();

                //ICollection c = h.Values;            //返回哈希表所有键/值对的值
                //IEnumerator ie = c.GetEnumerator();   //把哈希表的值集合转换为枚举器
                while (ie.MoveNext())                //遍历枚举器
                {
                    DictionaryEntry d = (DictionaryEntry)ie.Current;
                    string s = ((Student)d.Value).Answer();
                    //string s = ((Student)ie.Current).Answer();
                    Console.WriteLine(s);

                    
                }
                    Console.ReadKey();
            }   
            
        }
        
}
