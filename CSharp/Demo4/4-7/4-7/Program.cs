using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_7
{
    public delegate Person PointPerson(int i);  //声明委托，返回第i个人员
    public delegate int Position(Student s);    //声明委托，返回指定学生的位置
    public class Person                         //这是一个基类
    {
        public string name;
        public char sex;
        //构造函数
        public Person(string name, char sex)
        {
            this.name = name;
            this.sex = sex;
        }
    }
    public class Student : Person               //这是一个派生类
    {
        public string school;
        //构造函数
        public Student(string name, char sex, string school)
            : base(name, sex)
        {
            this.school = school;
        }
    }
    public class Persons                      //若干个人员的集合
    {
        private Person[] p = new Person[5];
        public Person this[int i]            //声明索引器
        {
            set
            {
                if (i < 0 || i >= p.Length) p[0] = value;
                else p[i] = value;
            }
        }
        public Person getPerson(int i)       //返回第i个人
        {
            if (i < 0 || i >= p.Length) return p[0];
            else return p[i];
        }
        public int getPos(Person per)       //返回某个人的位置
        {
            int k = -1;                     //如果此人不存在，返回-1
            for (int i = 0; i < p.Length; i++)
            {
                if (per.name == p[i].name && per.sex == p[i].sex)
                {
                    k = i;
                    break;
                }
            }
            return k;
        }
    }
    public class Students                  //若干个学生的集合
    {
        private Student[] p = new Student[5];
        public Student this[int i]        //声明索引器
        {
            set
            {
                if (i < 0 || i >= p.Length) p[0] = value;
                else p[i] = value;
            }
        }
        public Student getStudent(int i)   //返回第i个学生
        {
            if (i < 0 || i >= p.Length) return p[0];
            else return p[i];
        }
        public int getPos(Student per)    //返回指定学生的位置
        {
            int k = -1;                   //如果该生不存在，返回-1
            for (int i = 0; i < p.Length; i++)
            {
                if (per.name == p[i].name && per.sex == p[i].sex && per.school == p[i].school)
                {
                    k = i;
                    break;
                }
            }
            return k;
        }
    }
    public class TestDelegate
    {
        static void Main()
        {
            //创建学生集合并存入5个学生的信息
            Students s = new Students();
            s[0] = new Student("张云逸", '男', "电子科大成都学院");
            s[1] = new Student("王海", '男', "成都东软学院");
            s[2] = new Student("李若水", '女', "电子科大成都学院");
            s[3] = new Student("赵霞", '女', "电子科大成都学院");
            s[4] = new Student("梅岭", '男', "成都东软学院");

            //创建返回值为Person型的委托对象并指定引用Students集合的getStudent方法
            PointPerson point = new PointPerson(s.getStudent);
            for (int i = 0; i < 5; i++)
            {
                Person a = point(i);          //协变委托方法调用
                Console.WriteLine("姓名：{0}\t性别：{1}。", a.name, a.sex);
            }

            //创建人员集合并存入5个人的信息
            Persons p = new Persons();
            p[0] = new Person("许珊珊", '女');
            p[1] = new Person("尹佳云", '女');
            p[2] = new Person("周巍", '男');
            p[3] = new Person("杨森", '男');
            p[4] = new Person("刘通", '男');
            //创建参数为Student的委托对象，并指定引用Perons集合的getPos
            Position pos = new Position(p.getPos);
            int k = pos(new Student("周巍", '男', "电子科大成都学院")); //逆变委托方法调用
            Console.WriteLine("该生是第{0}个学生。", k + 1);


            Console.ReadKey();
        }
    }

}
