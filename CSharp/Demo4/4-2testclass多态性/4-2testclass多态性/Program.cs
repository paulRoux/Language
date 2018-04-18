using System;
public class Person        //这是一个基类
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
    //声明虚拟方法成员
    public virtual string Answer()
    {
        return string.Format("姓名：{0}，性别：{1}。", Name, Sex);
    }
}

public class Student : Person     //这是一个派生类
{
    //扩展数据成员
    public string School;     //学校
    public int Score;        //成绩
    //定义构造函数，自动调用基类的构造函数辅助完成字段的初始化
    public Student(string name, char sex, string school, int score): base(name, sex)
    {
        School = school;
        Score = score;
    }
    //覆盖基类的方法成员
    public override string Answer()
    {
        return string.Format("姓名：{0}，性别：{1}\n学校：{2}，成绩：{3}分。",Name, Sex, School, Score);
    }
}
public class Worker : Person     //这是一个派生类
{
    //扩展数据成员
    public string Department;   //部门
    public float Salary;        //薪水
    //定义构造函数，自动调用基类的构造函数辅助完成字段的初始化
    public Worker(string name, char sex, string depart, float salary): base(name,sex)
    {
        Department = depart;
        Salary = salary;
    }
    //覆盖基类的方法成员
    public override string Answer()
    {
        return string.Format("姓名：{0}，性别：{1}\n部门：{2}，薪水：{3}元。",Name, Sex, Department, Salary);
    }
}
class TestClass
{
    static void Main()
    {
        //创建学生对象
        Student s = new Student("张伟", '男', "电子科大成都学院", 480);
        Console.WriteLine("该学生信息如下：");
        Console.WriteLine(s.Answer());
        //创建员工对象
        Worker w = new Worker("王刚", '男', "生产车间", 1500);
        Console.WriteLine("\n"+"该员工信息如下：");
        Console.WriteLine(w.Answer());
        Console.ReadKey();
    }
}

