using System;
public sealed  class Person        //这是一个基类
{
    //定义数据成员
    public string Name;   //姓名
    public char Sex;      //性别
    //定义构造函数，以初始化字段
    public Person(string name, char sex)
    {
        Name = name;
        Sex = sex;
    }
    //public Person()
    //{
       
    //}
    //定义方法成员
    public string Answer()
    {
        return string.Format("姓名：{0}，性别：{1}。", Name, Sex);
    }
}

public class Student : Person     //这是一个派生类
{
    //扩展数据成员
    public string School;     //学校
    private int Score;        //成绩
    //定义构造函数，自动调用基类的构造函数辅助完成字段的初始化
    public Student(string name, char sex, string school, int score): base(name, sex)
    {
        School = school;
        Score = score;
    }
    //扩展方法成员
    public float Examine()   //返回考试成绩
    {
        return Score;
    }
}
class TestClass
{
    static void Main()
    {
        //创建Student对象
        Student s = new Student("张伟", '男', "西安理工大学", 520);
        Console.WriteLine("该生信息如下：");
        Console.WriteLine(s.Answer());                //调用对象继承来的方法
        Console.WriteLine("学校：{0}，考试成绩：{1}", s.School, s.Examine());
        Console.ReadKey();
    }
}
