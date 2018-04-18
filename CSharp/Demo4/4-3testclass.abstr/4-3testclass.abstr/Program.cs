using System;
using System.Collections;
//using System.Linq;
//using System.Text;

namespace _4_3testclass.abstr
{
    
    public abstract class Shape      //表示“形状”的抽象类型
    {
        private string m_id;         //定义形状的ID，一个私有字段
        //声明构造函数，用来设置属性Id
        public Shape(string s)
        {
            Id = s;
        }
        public string Id             //定义属性，用来操作私有字段id
        {
            get
            {
                return m_id;
            }
            set
            {
                m_id = value;
            }
        }
        // 定义一个只读的抽象属性 - 表示形状的面积
        public abstract double Area
        {
            get;
        }
        //重载从Ojbect类继承来的方法
        public override string ToString()
        {
            return Id + " 面积 = " + string.Format("{0:F2}", Area);
        }
    }
    public class Square : Shape           //正方形，从抽象类Shape派生
    {
        private int m_side;               //正方形的边长
        //声明构造函数，联合基类的构造函数对字段成员进行初始化
        public Square(int side, string id)
            : base(id)
        {
            m_side = side;
        }
        //重载继承来的抽象属性，得正方形的面积
        public override double Area
        {
            get
            {
                return m_side * m_side;
            }
        }
    }
    class TestClass
    {
        static void Main()
        {
            //创建一个边长为5的正方形对象
            Square s = new Square(5, "正方形");
            string result = s.ToString();
            Console.WriteLine(result);
            

           

            Console.ReadKey();

        }
    }

}
