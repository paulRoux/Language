using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace _4_4接口
{
        
    interface IStudent
    {   //声明属性成员
        string StudentID{get;set;}
        string Name { get;set;}
        char Sex { get;set;}
          //声明方法成员
        string Answer();
    }
    interface ISchool
    {   //声明属性成员
        string SchoolName { get;set;}
        string Address { get;set;}
        //声明方法成员
        string Answer();
    }
    public class Student :IStudent,ISchool   //这一个从多个接口继承的派生类
    {
        //定义私有字段
        private string studentID;    //学号
        private string name;         //姓名
        private char sex;            //性别
        private string schoolName;   //学校
        private string address;      //校址
        #region IStudent 成员
        //实现IStudent接口所定义的属性
        public string  StudentID
        {
	          get 
	        { 
		        return studentID; 
	        }
	          set 
	        { 
		        studentID = value; 
	        }
        }
        public string  Name
        {
	          get 
	        { 
		        return name ; 
	        }
	          set 
	        { 
		        name = value; 
	        }
        }
        public char  Sex
        {
	          get 
	        { 
		        return sex; 
	        }
	          set 
	        { 
		        sex = value; 
	        }
        }
        //显示实现接口的方法
        string  IStudent.Answer()
        {
            string s = "学号："+StudentID;
            s += " 姓名："+Name;
            s += " 性别："+Sex.ToString();
            return s;
        }
        #endregion
        #region ISchool 成员
        //实现ISchool接口所定义的属性
        public string  SchoolName
        {
	          get 
	        { 
		        return schoolName ; 
	        }
	          set 
	        { 
		        schoolName = value; 
	        }
        }
        public string  Address
        {
	          get 
	        { 
		        return address; 
	        }
	          set 
	        { 
		        address = value; 
	        }
        }
        //显示实现接口所定义的方法
        string ISchool.Answer()
        {
            string s = "\n学校：" + SchoolName;
            s += " 校址：" + Address;
            return s;
        }
        #endregion
        //构造函数，学校和校址可空白
        public Student(string id, string name, char sex)
        {
            StudentID = id;
            Name = name;
            Sex = sex;
            SchoolName = "";
            Address = "";
        }
        //构造函数，学校和校址不能空白
        public Student(string id, string name, char sex,string school,string address)
        {
            StudentID = id;
            Name = name;
            Sex = sex;
            SchoolName = school;
            Address = address;
        }
    }
    class TestClass
    {
        static void Main()
        {
            //创建学生数组对象
            Student[] s = new Student[2];
            //设置第一个学生的信息
            s[0] = new Student("2008100135", "张三丰", '男');
            string result = ((IStudent)s[0]).Answer();  //先强制类型转换，再调用方法
            Console.WriteLine("学生甲：\n{0}",result);
            //设置第二个学生的信息
            s[1] = new Student("20008050301", "黄衫女", '女', 
    "西安电子科大", "西安高新区");
            result = ((IStudent)s[1]).Answer();         //强制类型转换，再调用方法
            result += ((ISchool)s[1]).Answer();         //强制类型转换，再调用方法
            Console.WriteLine("学生乙：\n{0}", result);


            _4_4接口.附录.Program p = new _4_4接口.附录.Program();
            p.id = 4;
            Console.WriteLine(p.id);


            //Program q = new Program();


            Console.ReadKey();
        }
    }

}
